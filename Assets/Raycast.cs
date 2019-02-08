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

		if (Input.GetKey(KeyCode.Mouse0))
		{
			test.origin = camera.position + Vector3.forward * 2;
			test.direction = camera.forward * 200;
			hit.distance = 999f;


			bool rayjit = Physics.Raycast(test.origin,test.direction, out hit, Mathf.Infinity);

			if (rayjit)
			{
				//Debug.Log(hit.collider.gameObject.tag);
				Debug.DrawRay(test.origin,test.direction * hit.distance);

				if (hit.collider.gameObject.CompareTag("Zombie"))
				{
					Debug.Log(hit.collider.gameObject);
					hit.collider.gameObject.SetActive(false);

				}

			}
			
				
        }

        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(0);
        }
	}
}
