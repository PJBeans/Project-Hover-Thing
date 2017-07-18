using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLS : MonoBehaviour {
	public string url;
	// Use this for initialization
	void OnMouseDown() {
		Debug.Log ("Click Button");
		Application.OpenURL (url);
	}


}

