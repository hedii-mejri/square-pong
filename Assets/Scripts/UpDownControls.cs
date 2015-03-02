using UnityEngine;
using System.Collections;

public class UpDownControls : MonoBehaviour {

	public KeyCode moveUp = KeyCode.UpArrow;
	public KeyCode moveDown = KeyCode.DownArrow;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (moveUp)) {
			var paddle1 = GameObject.Find("PaddleL");
			paddle1.transform.Translate (0,0.1f,0);
			
			var paddle2 = GameObject.Find("PaddleR");
			paddle2.transform.Translate (0,-0.1f,0);
		}
		else if (Input.GetKey (moveDown)) {
			var paddle1 = GameObject.Find("PaddleL");
			paddle1.transform.Translate (0,-0.1f,0);
			
			var paddle2 = GameObject.Find("PaddleR");
			paddle2.transform.Translate (0,0.1f,0);
		}
		else if (!Input.anyKey) {
			var velocity = rigidbody2D.velocity;
			velocity.y = 0.0f;
			rigidbody2D.velocity = velocity;
		}

		var reset = rigidbody2D.velocity;
		reset.x = 0;
		rigidbody2D.velocity = reset;
	}
}
