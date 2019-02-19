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
    bool canShoot;
	private Ray test;
	RaycastHit hit;
    public Transform camera;
    public TextMeshProUGUI totalZombies;
	
    private void Start()
    {
        ammoCountTxt.text = ammo.ToString();
        canShoot = true;
        totalZombies.text = "";
    }
	// Update is called once per frame
	void Update () {
        totalZombies.text = GameManager.instance.zombiesList.Count.ToString();
        Debug.DrawRay(camera.position, camera.forward * 10);
        if(ammo <= 0)
            canShoot = false;
        if(canShoot)
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
                        GameManager.instance.zombiesList.Remove(gameObject);
                    }
            }
        }


        if (Input.GetKeyDown(KeyCode.R)){
            StartCoroutine("Reload");
        }
        if (Input.GetKeyDown(KeyCode.P)){
            SceneManager.LoadScene(0);
        }
	}

    public IEnumerator Reload()
    {
        canShoot = false;
        yield return new WaitForSeconds(2);
        ammo = 20;
        ammoCountTxt.text = ammo.ToString();
        canShoot = true;
    }
}
