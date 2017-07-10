using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnRot : MonoBehaviour {
	public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "UnRot") {
			player.transform.rotation = Quaternion.Euler (0, 0, 0);
		}
		
	}
}
