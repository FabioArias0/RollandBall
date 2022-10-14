using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//agregamos 

using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class JugadorController : MonoBehaviour
{
    //Declaro la variable RigidBody que uego asociaremos a nuestro jugador
    private Rigidbody rb;

    //Declaro la variable publica velocidad para poder modifcarla desde inspecto window

    public float velocidad;

    // Inicializo el contador de coleccionables
    private int contador;
    
    // Inicializo variables para los textos
    public Text TextoContador;

    public AudioClip sonidoMoneda;

    private AudioSource Moneda;


    [SerializeField] private GameObject  MenuPerdida;
    [SerializeField] private GameObject  MenuGanar;

    

    


    // Start is called before the first frame update

    void Start()
    {
        //capturo esa variable al iniciar el juego
        rb=GetComponent<Rigidbody>();

        //Inicio contador en cero
        contador=0;

        //Actualizo el texto del contador por primera vez
        setTextoContador();

        
        Moneda = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    //Para que se sincronice con los frames de fisica del juego
    void FixedUpdate()
    {
        float MovimientoX = Input.GetAxis("Horizontal");
        float MovimientoY = Input.GetAxis("Vertical");

        // Un vector 3 es un trio de posicones en el espaico xyz,
        // en este caso el que corresponde al moviento.

        Vector3 movimiento = new Vector3(MovimientoX, 0.0f,MovimientoY);
        // Asigno ese movimiento o desplazamienot a mi RigidBody, multiplicado
        // por la velodad que quiera darle.

        rb.AddForce(movimiento*velocidad);
        
    }
    //Se ejecuta al entrar a un objeto con la opcion isTrigger
    //seleccionada

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            
            //desactivo el objeto
            other.gameObject.SetActive(false);
            // Incremento el contador en uno (tambien se puede
            //hacer como contador++)
            contador=contador+1;

            //Actualizo el texto del contador
            setTextoContador();

            Moneda.PlayOneShot(sonidoMoneda);

            
        }
        else if (other.gameObject.CompareTag("DeadLevel")) 
        {
            
                MenuPerdida.SetActive(true);
            
        }
    }

    //Actualizo el texto del contado (o muestro el de ganar
    // si has cogido todas las moendas)

    void setTextoContador(){

        TextoContador.text="Contador:"+contador.ToString();
        if(contador>=12){
            
            MenuGanar.SetActive(true);
        }



    }

}
