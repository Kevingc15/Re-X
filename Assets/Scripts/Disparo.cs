using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//Creamos un tipo enumerado para definir la dirección
public enum Direccion
{
    Horizontal, Vertical
}
public class Disparo : MonoBehaviour
{
    public Direccion DireccionArma = Direccion.Horizontal;
    public float Velocidad = 50.0F;
   // public GameObject DisparoPref;
    
    Rigidbody rb2;
    // Use this for initialization
    void Start()
    {
        rb2 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Establecemos su velocidad y su dirección
        if (DireccionArma == Direccion.Horizontal)
        {
            //Movemos el arma en horizontal
            rb2.transform.Translate(new Vector3(Velocidad, 0, 0) );
        }
        else
        {
            //Movemos el arma en vertical
            rb2.transform.Translate(new Vector3(0, Velocidad, 0));
        }

    }

}



