using UnityEngine;
using System.Collections;

public class BubbleWeaponController : MonoBehaviour {

	private float bulletSpeed = 100;
	public GameObject[] ammo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Flip(){

	}

	void FixedUpdate () {    

		float h = Input.GetAxis ("Horizontal");
		Vector2 v;
		if (h > 0)
				v = new Vector2 (1, 0);
		else
				v = new Vector2 (-1, 0);
		// Fire a bullet.
		if(Input.GetKeyDown(KeyCode.Z)){
			int ammoIndex = 0; 
			GameObject bullet = (GameObject)Instantiate(ammo[ammoIndex], transform.position, transform.rotation);
			//bullet.transform.LookAt (v);
			//Rigidbody2D bullet = Instantiate(ammo[ammoIndex],transform.position,Quaternion.Euler(new Vector3(0,0,100f))) as Rigidbody2D;
			bullet.rigidbody2D.velocity = new Vector2(bulletSpeed,0);
		}
	}

}
