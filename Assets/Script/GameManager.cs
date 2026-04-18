using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    
    public float IniciativaPlayerIA = Random.Range(0, 9);
    public float IniciativaPlayer = Random.Range(0, 9);
    public bool PlayerTurn = false;
    public bool PlayerIATurn = false;
    public bool AtaquePlayer = false;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (IniciativaPlayerIA > IniciativaPlayer)
        {
            PlayerIATurn = true;
            Debug.Log("le toca al enemigo");
        }
        else
        {
            PlayerTurn = true;
            Debug.Log("le toca al jugador");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerTurn = true && PlayerIATurn == false)
        {
            Debug.Log("tira el dado");
        }
        if(PlayerIATurn = true && PlayerTurn == false)
        {
            Debug.Log("Espera tu turno");
            
        }
        if(AtaquePlayer == true)
        {
            Enemigo.Instance.Dmg = 25f;
        }
    }
}
