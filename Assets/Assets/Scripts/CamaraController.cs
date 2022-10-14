using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{

    //Referencia de nuestro juador
    public GameObject Jugador;
    // Para registrar la diferencia entre la posicion de la camara
    // y la del jugador
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //Diferencia entre la posicion de la camara y la del jugador
        offset=transform.position - Jugador.transform.position;
        
    }

    // Update is called once per frame
    // Se ejecuta cada frame, pero despues de haber porcesado tod.
    // es mas exacto para la camara
    void LateUpdate()
    {
        
        // actualizo la poscion de la camara
        transform.position=Jugador.transform.position + offset;
    }
}
