using UnityEngine;
using System.Collections;

public class itemSpawnScript : MonoBehaviour {


	public Rigidbody2D mushroom;
	public Rigidbody2D fireFlower;
	private Rigidbody2D itemC;
	ChildScript testItem;
	contactCheck stop;
	Player_controller playerRefer;

	// Use this for initialization
	void Start () {
		playerRefer = GameObject.Find ("Mario").GetComponent<Player_controller> ();
		testItem = GameObject.FindGameObjectWithTag("block").GetComponentInChildren<ChildScript>();
		stop = GameObject.FindGameObjectWithTag ("block").GetComponentInChildren<contactCheck> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(testItem.testValue && stop.control == 1)
        {
			if(playerRefer.isSuper == false)
				itemC = (Rigidbody2D)Instantiate(mushroom, transform.position, transform.rotation);
			else if(playerRefer.isSuper == true)
				itemC = (Rigidbody2D)Instantiate(fireFlower, transform.position, transform.rotation);

        }

	}
		
}
