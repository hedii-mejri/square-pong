using UnityEngine;
using System.Collections;

public class LeftRightControls : MonoBehaviour {
	public KeyCode moveLeft = KeyCode.LeftArrow;
	public KeyCode moveRight = KeyCode.RightArrow;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (var i = 0; i < Input.touchCount; ++i) {
			Touch touch = Input.GetTouch(i);
			if (touch.phase == TouchPhase.Began || Input.GetKey(moveLeft)) {
				//if (touch.position.x > (Screen.width/2)) {
					Debug.Log(touch.position);
				//}
			}
		}
		if (Input.GetKey (moveLeft)) {

			var paddle1 = GameObject.Find("PaddleU");
			paddle1.transform.Translate (0,-0.1f,0);
			
			var paddle2 = GameObject.Find("PaddleB");
			paddle2.transform.Translate (0,-0.1f,0);

		}
		else if (Input.GetKey (moveRight)) {

			var paddle1 = GameObject.Find("PaddleU");
			paddle1.transform.Translate (0,0.1f,0);
			
			var paddle2 = GameObject.Find("PaddleB");
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
