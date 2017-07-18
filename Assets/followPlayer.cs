using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour {

	public Transform player;
	public Vector3 offset;
	//Camera Rotation Values
	public float xRot;
	public float yRot;
	public float zRot;

	// Update is called once per frame
	void Update () {
		transform.position = player.position + offset;
		transform.eulerAngles = new Vector3 (xRot,yRot,zRot);
	}
}
