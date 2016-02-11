using UnityEngine;
using System.Collections;

public class FireFlowerScript : MonoBehaviour {

	Player_controller playRef;
	// Use this for initialization
	void Start () {
		playRef = GameObject.Find ("Mario").GetComponent<Player_controller> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.name == "Mario" && playRef.isSuper == true)
		{
			Destroy(this.gameObject);
			Debug.Log("FIRETIME!");
			playRef.isSuper = false;
			playRef.isSuperFire = true;
		}
	}
}
