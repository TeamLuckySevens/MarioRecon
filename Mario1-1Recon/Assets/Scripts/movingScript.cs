using UnityEngine;
using System.Collections;

public class movingScript : MonoBehaviour {

	Player_controller playRef;
	// Use this for initialization
	void Start () {
		playRef = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player_controller>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (Vector2.right * Time.deltaTime * 2f);
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//Debug.Log("sofarsogood");
		if (col.gameObject.tag == "Player") 
		{
			playRef.isSuper = true;
			Debug.Log("gotIT");
		}
	}
}
