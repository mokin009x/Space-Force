using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {
   RaycastHit raycastHit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out raycastHit, Mathf.Infinity))
            { if (raycastHit.collider.gameObject.tag == "Zombie")
                {
                    Destroy(raycastHit.collider.gameObject);
                }
            }
        }
	}
}
