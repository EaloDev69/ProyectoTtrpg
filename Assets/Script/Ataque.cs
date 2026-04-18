using UnityEngine;

public class Ataque : MonoBehaviour
{
    public static Ataque Instance { get; private set; }
    
    public float Exito;

    public float Unidades;

    public float Decenas;
    
    public float DañoFinal;
    
    public void PruebaDado ()
    {
        Exito = Random.Range(0, 8);
        if (3 >= Exito)
        {
            pifia();
        }else
        {
            Daño();
            
        }

    }
    
    
    public void pifia()
    {
        Debug.Log("no has logrado la tirada");
        GameManager.Instance.PlayerTurn = false;
    }
    
    public void Daño()
    {
        Decenas= Random.Range(0, 8) * 10;
        Unidades = Random.Range(0, 8);
        
        DañoFinal = Decenas + Unidades;
        
        if( DañoFinal >= 90)
        {
         pifia();
        }
        if(DañoFinal < 50)
        {
        pifia();
        }
        if ( 50 < DañoFinal && DañoFinal < 90 )
        {
            GameManager.Instance.AtaquePlayer = true;
        }
    }
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.PlayerTurn == true)
        {
            PruebaDado();
        }
        else
        {
            Debug.Log("no es tu turno");
        }
    }
}
