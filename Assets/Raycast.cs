using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour {
   RaycastHit raycastHit;
    public GameObject camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(camera.transform.position, camera.transform.forward);

		if (Input.GetKey(KeyCode.Mouse0))
        {
            if (Physics.Raycast(camera.transform.position, camera.transform.forward, out raycastHit, Mathf.Infinity))
            { if (raycastHit.collider.gameObject.tag == "Zombie")
                {
                    Destroy(raycastHit.collider.gameObject);
                }
            }
        }
	}
}
