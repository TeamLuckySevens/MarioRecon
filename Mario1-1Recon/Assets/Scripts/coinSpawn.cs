using UnityEngine;
using System.Collections;

public class coinSpawn : MonoBehaviour {

	public Rigidbody2D item;
	public Rigidbody2D itemC;
	ChildScript2 testItem;
	coinScript stop;
	
	// Use this for initialization
	void Start () {
		//testItem = gameObject.GetComponent<ChildScript>();
		testItem = GameObject.FindGameObjectWithTag("cBlock").GetComponentInChildren<ChildScript2>();
		stop = GameObject.FindGameObjectWithTag ("cBlock").GetComponentInChildren<coinScript> ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(testItem.testValue3 && stop.controlF == 1)
		{
			itemC = (Rigidbody2D)Instantiate(item, transform.position, transform.rotation);
		}
		
	}
}
