using UnityEngine;

public class FinalBoss : BaseEntity
{

    private int buffCount = 0;
    public FinalBoss(string name, int life, int attack, int defense)
       : base(name, life, attack, defense)
    {
        GameObject go = new GameObject(name);
        FinalBoss bos = go.AddComponent<FinalBoss>();
        bos.name = name;
        bos.life = life;
        bos.attack = attack;
        bos.defense = defense;
    }

    private void Start()
    {
        ImprimirEstadisticas();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            AplicarBuff("ataque", 5);
            AplicarBuff("defensa", 5);
            AplicarBuff("salud", 5);
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            RecibirDanio(Random.Range(10, 30));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            RecibirDanio(5);
        }
    }

    public void AplicarBuff(string tipo, int cantidad)
    {
        if (cantidad < 0) return;

        switch (tipo.ToLower())
        {
            case "ataque":
                attack += cantidad;
                break;
            case "defensa":
                defense += cantidad;
                break;
            case "salud":
                life += cantidad;
                break;
            default:
                Debug.Log("Tipo de buff inválido");
                return;
        }

        buffCount++;
        ImprimirEstadisticas();

        if (buffCount >= 4)
        {
            Destroy(this.gameObject, 1);
        }
    }
    private void RecibirDanio(int cantidad)
    {
        int danioRecibido = Mathf.Max(0, cantidad - defense);
        life -= danioRecibido;
        Debug.Log(name + " recibió " + danioRecibido + " de daño. Vida restante: " + life);
        if (life <= 0)
        {
            Destroy(this.gameObject, 0);
        }
    }
    private void OnDestroy()
    {
        Debug.Log("El jefe final ha sido derrotado.");
    }

}
