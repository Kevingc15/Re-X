using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour {

    public GameObject Seguir;
    public Vector2 PosMinCam, PosMaxCam;
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float posX = Seguir.transform.position.x;
        float posY = Seguir.transform.position.y;

        transform.position = new Vector3(
            Mathf.Clamp(posX, PosMinCam.x, PosMaxCam.x),
            Mathf.Clamp(posY, PosMinCam.y, PosMaxCam.y),
            transform.position.z);
    }
}
