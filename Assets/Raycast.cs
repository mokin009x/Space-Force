using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Raycast : MonoBehaviour
{
	private Ray test;
	RaycastHit hit;
    public Transform camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(camera.position, camera.forward * 10);

		if (Input.GetKey(KeyCode.Mouse0))
		{
			test.origin = camera.position;
			test.direction = camera.forward;
			bool rayjit = Physics.Raycast(test, out hit, 20f);
			
	            if (rayjit && hit.collider.gameObject.CompareTag("Zombie"))
                {
	                Debug.Log(hit.collider.gameObject);
	                hit.collider.gameObject.SetActive(false);
	                Debug.Log(rayjit);

                }
        }

        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(0);
        }
	}
}
