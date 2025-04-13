using UnityEngine;

public class GenerarBoss : MonoBehaviour
{
    private void Start()
    {
        FinalBoss bos = new FinalBoss("Pepe The Frog", 20, 5, 200);
        Destroy(this.gameObject,0);
    }
}
