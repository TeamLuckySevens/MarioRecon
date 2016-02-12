using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
	public bool isPaused;
	public AudioClip pauseClip;
	public GameObject pauseTxt;

	// Use this for initialization
	void Start () { 
		
		
	}

	// Update is called once per frame
	void Update () {

		AudioSource sound = GetComponent<AudioSource> ();
		sound.clip = pauseClip;

		if ( Input.GetKeyDown(KeyCode.Return)) {

			isPaused = !isPaused;

			if (isPaused == false) { 
				Time.timeScale = 1f;
				pauseTxt.SetActive(false);
				sound.Play ();

			}
			if (isPaused == true){
				Time.timeScale = 0f; 
				sound.Play ();
				pauseTxt.SetActive(true);
			}


		}



		if (Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();
	}
}
