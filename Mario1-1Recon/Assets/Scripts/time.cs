using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class time : MonoBehaviour {

	public Text txt; 
	float timer = 400f; 


	// Update is called once per frame 
	void Update () {

		if (timer > 0) {
			timer -= Time.deltaTime *2.5f;
			//Debug.Log (Mathf.Round(timer));
			txt.text = " " +(Mathf.Round( timer));
		}
	}
}