using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Jugar(){
        Time.timeScale=1f;
        SceneManager.LoadScene(1);
        
    }

    public void QuitarJuego(){
        Application.Quit();
        Debug.Log("Saliendo del Juego");
    }
}
