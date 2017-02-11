using UnityEngine;
using System.Collections;

public class bazooka : MonoBehaviour {

	public float shootForce;
	public float fireTime = 0.33f;
	public float projectileLifetime = 5f;
	public Transform muzzlePoint;
	public GameObject projectile;
	public GameObject fire;
	public float multiplier = -6f;
	public float multiplier2 = -6f;

	private float timeToFire;

	public float rotationsPerMinute = 20f;

	// Use this for initialization
	void Start () {
		timeToFire = 0f;
		//multiplier = -6f;
		//multiplier2 = -6f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 angle = transform.eulerAngles;
		if (angle.x < 80f) {
			transform.Rotate (multiplier * rotationsPerMinute * Time.deltaTime, 0, 0);
			//multiplier = multiplier * -1f;
		}
		else {
			multiplier = multiplier * -1f;
			// while greater than zero here freezes the computer
			//if (angle.x > 0)
			transform.Rotate (multiplier * rotationsPerMinute * Time.deltaTime, 0, 0);
			//multiplier = multiplier * -1f;
		}

		if (Input.GetKeyDown (KeyCode.Alpha1) || Input.GetKeyDown (KeyCode.Alpha2)){   
			
			transform.Rotate (0, 180f, 0);

			if (angle.x > 80f) {
				transform.Rotate (multiplier2 * rotationsPerMinute * Time.deltaTime, 0, 0);
				//multiplier = multiplier * -1f;
			}
			else {
				multiplier2 = multiplier2 * -1f;
				// while greater than zero here freezes the computer
				//if (angle.x > 0)
				transform.Rotate (multiplier2 * rotationsPerMinute * Time.deltaTime, 0, 0);
				//multiplier = multiplier * -1f;
			}
		}

		//if (Input.GetKeyDown (KeyCode.Alpha2)){

			//transform.Rotate (0, 180f, 0);

			//if (angle.x < 80f) {
				//transform.Rotate (multiplier * rotationsPerMinute * Time.deltaTime, 0, 0);

			//}
			//else {
				//multiplier = multiplier * -1f;
				//transform.Rotate (multiplier * rotationsPerMinute * Time.deltaTime, 0, 0);
			//}
		//}
			


		timeToFire -= Time.deltaTime;

		if (Input.GetMouseButton (0) && (timeToFire <= 0f)) 
		{ GameObject currProjectile = (GameObject)Instantiate (projectile, muzzlePoint.position, muzzlePoint.rotation);
		  GameObject currFire = (GameObject)Instantiate (fire, muzzlePoint.position, muzzlePoint.rotation);
			currProjectile.GetComponent<Rigidbody> ().AddForce (-muzzlePoint.up * shootForce);
			Destroy (currProjectile, projectileLifetime);
			Destroy (currFire, 2.0f);
			timeToFire = fireTime;
		}
	}
}
