using UnityEngine;
using System.Collections;

public class DieExplode : MonoBehaviour {

	public GameObject faceExplosion;

	// Use this for initialization
	void OnCollisionEnter (Collision c) {
		Object thisExplotion;
		thisExplotion = Instantiate (faceExplosion, transform.position, Quaternion.identity);
		Destroy (thisExplotion, 0.5f);
		Destroy (gameObject);
	}
}
