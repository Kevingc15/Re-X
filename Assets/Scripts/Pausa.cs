using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour {

    public bool Activo;
    public Canvas Canvas;
	// Use this for initialization
	void Start () {
        Canvas = GetComponent<Canvas>();
        Canvas.enabled = false;
	}

    public void CambiarEscena(string Nombre)
    {

        SceneManager.LoadScene(Nombre);
    }
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Activo = !Activo;
            Canvas.enabled = Activo;
            Time.timeScale = (Activo) ? 0 : 1f;
        }
	}
}
