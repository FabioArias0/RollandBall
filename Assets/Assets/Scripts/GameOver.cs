using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Reiniciar(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale=1f;
    }

    public void QuitarJuego(){
        Application.Quit();
        Debug.Log("Saliendo del Juego");
    }

    public void MainMenu(string nombre){
        SceneManager.LoadScene(nombre);
    }


}
