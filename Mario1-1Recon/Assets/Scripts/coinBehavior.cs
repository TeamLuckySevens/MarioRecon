using UnityEngine;
using System.Collections;

public class coinBehavior : MonoBehaviour {

	public int controlCoin = 0;
	private Vector2 posA3;
	private Vector2 posB3;
	ChildScript2 testing2;

	// Use this for initialization
	void Start () {
		//testing2 = GameObject.FindGameObjectWithTag("cBlock").GetComponentInChildren<ChildScript2>();
	}
	
	// Update is called once per frame
	void Update () {
		

		deleteItem ();

			
			
			
	}


	IEnumerator deleteItem(){

		print ("SCUAK IT");
		yield return new WaitForSeconds (.2f);
		Destroy (this.gameObject);
	}
}

