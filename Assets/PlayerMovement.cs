using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	public float up;
	public float fall;
	public float jump;
	public Transform player;
	public GameObject other;

	//These values are for rotating the camera upon colliding with an object.
	public Transform Camera;
	public float xRot;
	public float yRot;
	public float zRot;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		{
			if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Stationary) {
				rb.AddForce (0, up * Time.deltaTime, 0);
			}

				if (Input.GetKey ("w")) {
					rb.AddForce (0, up * Time.deltaTime, 0);
				}
		


			}
		}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Obst") {
			Debug.Log ("Collide with Obst Tag");
			rb.AddForce (0, -fall * Time.deltaTime, 0);
		}
		if (col.gameObject.tag == "Ground") {
			Debug.Log ("Collide with Ground Tag");
		}
		if (col.gameObject.tag == "Silly") {
			Debug.Log ("Collide with Silly");
			rb.AddForce (0, fall * Time.deltaTime, 0);

		}
		if (col.gameObject.tag == "Goal") {
			Debug.Log ("Collide with Goal");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
	}
		if (col.gameObject.tag == "Laser") {
			Debug.Log ("Collide with Laser Tag");
			Destroy (gameObject);
	
	}
		if (col.gameObject.tag == "Key") {
			Debug.Log ("Collide with Key tag");
			Destroy(other);
	}
		if (col.gameObject.tag == "xJump") {
			Debug.Log ("Collide with xJump Tag");
			rb.AddForce (jump, 0, 0);
	}
		if (col.gameObject.tag == "zJump") {
			Debug.Log ("Collide with zJump Tag");
			rb.AddForce (0, 0, jump);
	}
		if (col.gameObject.tag == "RotateCam") {
			Debug.Log ("Collide with RotateCame Tag");
			Camera.transform.eulerAngles = new Vector3 (0, yRot, 0);

}
}
}

	
