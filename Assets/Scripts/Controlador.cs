using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controlador : MonoBehaviour {

	public void CambiarEscena(String Nombre)
    {
       
        SceneManager.LoadScene(Nombre);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
