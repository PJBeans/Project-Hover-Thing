using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody rb;
	public float speed;
	public float up;
	public float fall;
	public Transform player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		if (Input.GetKey("w")) {
			rb.AddForce (0, up * Time.deltaTime, 0);
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
}
}
