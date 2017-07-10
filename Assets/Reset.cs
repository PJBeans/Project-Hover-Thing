using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {
	public Transform player;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
		void Update () {

		}

		void OnMouseDown (){
			Debug.Log ("Click Reset");
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
}
