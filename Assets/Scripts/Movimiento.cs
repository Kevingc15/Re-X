using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movimiento : MonoBehaviour {

    Rigidbody2D rb2d;
    Animator Anim;
    public float Vel = 5f;
    public float  MaxVel = 10f;
    public bool grounded;
    public float FuerSalto = 10;
    private bool Salto;
    public bool Muerto;
    
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
	}

    void Update()
    {
        
        if (Input.GetButtonDown("Jump")&& grounded)
        {
            Salto = true;
        }

        //if (Muerto)
        //{
          //  SceneManager.LoadScene();
        //}
    }
    void FixedUpdate () {
        float Hor = Input.GetAxis("Horizontal");
        float Ver = Input.GetAxis("Vertical");
        Anim.SetFloat("Caminar", Hor);
        rb2d.AddForce(Vector2.right * Vel * Hor);

        if(rb2d.velocity.x > MaxVel)
        {
            rb2d.velocity = new Vector2(MaxVel, rb2d.velocity.y);
        }
        if (rb2d.velocity.x < -MaxVel)
        {
            rb2d.velocity = new Vector2(-MaxVel, rb2d.velocity.y);
        }

        if (Salto)
        {
            rb2d.AddForce(Vector2.up * FuerSalto, ForceMode2D.Impulse);
            Salto = false;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            
        }
    }
}
