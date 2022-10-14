using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPausa : MonoBehaviour
{

    [SerializeField] private GameObject  botonPausa;
    [SerializeField] private GameObject  menuPausa;

    public void pausa(){
        Time.timeScale=0;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void renaudar(){
        Time.timeScale=1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }


   
}
