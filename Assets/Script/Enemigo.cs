using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public static Enemigo Instance { get; private set; }
    private float Salud = 100;
    public float Dmg = 0;
    public float DadoAC = 0;
    public float Damage = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Dmg != 0)
        {
            Salud -= Dmg;
        }
        if (Salud <= 0)
        {
            Destroy(gameObject);
        }
        
    }
    
    public void DañoJugador()
    {
        DadoAC = Random.Range(0, 19);
        if(DadoAC < 14)
        {
            DadoDaño();
        } else if(DadoAC >= 14)
        {
          Debug.Log("enemigo fallo");
          GameManager.Instance.PlayerTurn = true;
          GameManager.Instance.PlayerIATurn = false;
        }
    }
    
    public void DadoDaño()
    {
        Damage = Random.Range(0, 100);
        PlayerManager.Instance.Damage = Damage;
    }
}
