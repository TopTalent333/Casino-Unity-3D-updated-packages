using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {

	public GameObject center;

	void Start() {
		Vector3 vector = (transform.position - center.transform.position).normalized;
		GetComponent<Rigidbody2D>().AddForce((new Vector2(vector.y, (-1 * vector.x))) * -1000);
	}

	// Update is called once per frame
	void FixedUpdate () {
		Rigidbody2D body = GetComponent<Rigidbody2D> ();
		Vector3 vector = (transform.position - center.transform.position).normalized;
		body.AddForce(new Vector2( body.velocity.x * -0.2f , body.velocity.y * -0.2f));
	}
}
