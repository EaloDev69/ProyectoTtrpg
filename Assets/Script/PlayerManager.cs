using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance { get; private set; }
    public float salud = 100f;

    public float Damage = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Damage != 0)
        {
            salud -= Damage;
        }
        if (salud <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void getDamage(float Damage)
    {
        
    }
}
