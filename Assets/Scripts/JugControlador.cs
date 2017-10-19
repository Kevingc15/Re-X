using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugControlador : MonoBehaviour {

    public GameObject DisparoPrefab;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		if (DisparoPrefab != null && Input.GetButtonDown("Fire1"))
        {
            Disparo xDisparo = GetComponent<Disparo>();
            if (Input.GetAxis("Vertical") > 0)
            {
                xDisparo.DireccionArma = Direccion.Vertical;
                xDisparo.Velocidad = Mathf.Abs(xDisparo.Velocidad);
            }

            else if (Input.GetAxis("Vertical") < 0)
            {
                //Ataque hacia abajo
                xDisparo.DireccionArma = Direccion.Vertical;
                xDisparo.Velocidad = Mathf.Abs(xDisparo.Velocidad);
            }
            else if (Input.GetAxis("Horizontal") > 0)
            {
                //Ataque hacia la derecha
                xDisparo.DireccionArma = Direccion.Horizontal;
                xDisparo.Velocidad = Mathf.Abs(xDisparo.Velocidad);
            }
            else if (Input.GetAxis("Horizontal") < 0)
            {
                //Ataque hacia la izquierda
                xDisparo.DireccionArma = Direccion.Horizontal;
                xDisparo.Velocidad = Mathf.Abs(xDisparo.Velocidad);
            }

            //Creamos una instancia del prefab en nuestra escena, concretamente en la posición de nuestro personaje
            Instantiate(DisparoPrefab, transform.position, Quaternion.identity);
        }
	}
}
