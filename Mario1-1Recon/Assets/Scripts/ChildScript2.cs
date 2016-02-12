using UnityEngine;
using System.Collections;

public class ChildScript2 : MonoBehaviour {

	public bool testValue3 = false;
	public bool coins = false;
	public bool bump = false;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			testValue3 = true;
			coins = true;
			bump = true;
		}
		
	}
}
