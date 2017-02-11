using UnityEngine;
using System.Collections;

public class Firexplosion : MonoBehaviour {

	public GameObject fireExplosion;

	// Use this for initialization
	void OnMouseDown() {
		Object thisExplotion2;
		thisExplotion2 = Instantiate (fireExplosion, transform.position, Quaternion.identity);
		Destroy (thisExplotion2, 2.0f);
		//Destroy (gameObject);
	}
}
