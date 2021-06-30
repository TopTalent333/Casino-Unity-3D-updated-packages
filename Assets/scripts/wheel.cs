using UnityEngine;
using System.Collections;

public class wheel : MonoBehaviour {

	public float speed = 1.1f;
	private float position = 0.0f;
	private float initradius = 4.75f;
	private float minradius = 3.28f;
	private CircleCollider2D collider;

	// Use this for initialization
	void Start () {
		collider = transform.GetComponent<CircleCollider2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		speed *= 0.995f;
		if (collider.radius > minradius)
			collider.radius *= 0.995f;	
		else
			collider.radius = minradius;	
		position-=speed;
		position = position % 360;
		transform.rotation = Quaternion.Lerp ( transform.rotation, Quaternion.Euler(0,0,position), 1);
	}
}
