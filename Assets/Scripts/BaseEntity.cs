using UnityEngine;

abstract public class BaseEntity : MonoBehaviour
{
    protected string name;
    protected int life;
    protected int attack;
    protected int defense;

    public string Name => name;

    public BaseEntity(string _name, int _life, int _attack, int _defense)
    {
        name = _name;
        life = _life;
        attack = _attack;
        defense = _defense;
    }
    protected virtual void ImprimirEstadisticas()
    {
        Debug.Log("Nombre: " +  name);
        Debug.Log("Vida: " +  life);
        Debug.Log("Ataque: " +  attack);
        Debug.Log("Defensa: " +  defense);
    }
}
