using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAround : MonoBehaviour {

   float ax = 50f;
   Vector3 Vel = new Vector3(0, 0, 0);


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyUp(KeyCode.Z))
        {
            FindObjectOfType<Camera>().clearFlags = CameraClearFlags.Nothing;
        }
        if(transform.position.y < 0)
        {
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        }
        Vel.x = Input.GetAxis("Horizontal")*ax;
        Vel.y = Input.GetAxis("Vertical")*ax;

        //Vel += KeyCode * ax;

        this.GetComponent<Rigidbody>().AddForce(Vel);
        //this.gameObject.transform.position += Vel;
      
	}
}
