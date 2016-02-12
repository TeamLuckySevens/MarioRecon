using System;
using UnityEngine;

public class Restarter : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			Debug.Log ("PLAYER HIT");
			Application.LoadLevel(Application.loadedLevel);
		}
		if (other.tag != "Player")
			Destroy (other.gameObject);
	}
}

