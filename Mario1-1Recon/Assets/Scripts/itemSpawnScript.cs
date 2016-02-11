using UnityEngine;
using System.Collections;

public class itemSpawnScript : MonoBehaviour {


	public Rigidbody2D item;
	private Rigidbody2D itemC;
	ChildScript testItem;
    //playerMove playerMoveRef;
	contactCheck stop;

	// Use this for initialization
	void Start () {
		//testItem = gameObject.GetComponent<ChildScript>();
		testItem = GameObject.FindGameObjectWithTag("block").GetComponentInChildren<ChildScript>();
		//playerMoveRef = GameObject.FindGameObjectWithTag ("Player").GetComponent<playerMove>();
		stop = GameObject.FindGameObjectWithTag ("block").GetComponentInChildren<contactCheck> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(testItem.testValue && stop.control == 1)
        {
			itemC = (Rigidbody2D)Instantiate(item, transform.position, transform.rotation);
        }

	}
		
}
