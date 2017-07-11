using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text timerText;
	private float secCount;
	private int minCount;
	private int hrCount;

	void Update(){
		UpdateTimerUI ();
	}
	public void UpdateTimerUI() {
		secCount += Time.deltaTime;
		timerText.text = hrCount + "h:" + minCount + "m" + (int)secCount + "s";
		if (secCount >= 60) {
			minCount++;
			secCount = 0;
		} else if (minCount >= 60) {
			hrCount++;
			minCount = 0;

		}
}
}
