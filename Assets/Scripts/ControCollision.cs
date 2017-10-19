using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControCollision : MonoBehaviour {

    private Movimiento jugador;
	void Start () {
        jugador = GetComponentInParent<Movimiento>();
	}
	
	void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            jugador.grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Suelo")
        {
            jugador.grounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Debajo")
        {
            jugador.Muerto = true;
        }
    }
}
