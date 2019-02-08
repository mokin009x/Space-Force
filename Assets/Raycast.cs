using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Raycast : MonoBehaviour
{
    public Text ammoCountTxt;
    private int ammo = 20;
	private Ray test;
	RaycastHit hit;
    public Transform camera;
	
    private void Start()
    {
        ammoCountTxt.text = ammo.ToString();
    }
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(camera.position, camera.forward * 10);
        if(ammo > 0)
        {
	        if (Input.GetKeyDown(KeyCode.Mouse0))
	        {
                ammo--;
                ammoCountTxt.text = ammo.ToString();
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
        }


        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(0);
        }
	}
}
