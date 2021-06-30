using UnityEngine;
using System.Collections;

public class center : MonoBehaviour {

	public float gravity = 100f;
	
	// Update is called once per frame
	void FixedUpdate () {
		foreach (GameObject o in UnityEngine.Object.FindObjectsOfType<GameObject>()) {
			if(o.GetComponent<Rigidbody2D>()){
				Vector3 vector = (transform.position - o.transform.position).normalized;
				o.GetComponent<Rigidbody2D>().AddForce(vector * gravity);
			}
		}

	}
}
