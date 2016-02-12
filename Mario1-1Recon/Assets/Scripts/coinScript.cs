using UnityEngine;
using System.Collections;

public class coinScript : MonoBehaviour {

	public int controlF = 0;
	private Vector2 posA2;
	private Vector2 posB2;
	ChildScript2 testing2;
	public bool bump = false;
	// Use this for initialization
	void Start () {
		testing2 = GameObject.FindGameObjectWithTag("cBlock").GetComponentInChildren<ChildScript2>();
		bump = GameObject.FindGameObjectWithTag("cBlock").GetComponentInChildren<ChildScript2>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		if (bump == false) {
			posA2 = new Vector2 (transform.position.x, transform.position.y + 2);
			posB2 = new Vector2 (transform.position.x, transform.position.y - 2);
			if (testing2.testValue3 == true) {
				//Debug.Log("YES");
				
				if (controlF < 5) {
					controlF = 0;
					transform.position = Vector2.Lerp (transform.position, posA2, Time.deltaTime);
					controlF++;
				} else if (controlF < 10) {
					transform.position = Vector2.Lerp (transform.position, posB2, Time.deltaTime);
					controlF++;
				} else if (controlF == 10) {
					controlF = 0;
					testing2.testValue3 = false;
					bump = true;
				}
				
				

				
			}


		}
	}






}

