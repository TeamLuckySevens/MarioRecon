using UnityEngine;
using System.Collections;

public class coinBehavior : MonoBehaviour {

	public int controlCoin = 0;
	private Vector2 posA3;
	private Vector2 posB3;
	ChildScript2 testing2;

	// Use this for initialization
	void Start () {
		testing2 = GameObject.FindGameObjectWithTag("cBlock").GetComponentInChildren<ChildScript2>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		posA3 = new Vector2(transform.position.x, transform.position.y + 20);
		posB3 = new Vector2(transform.position.x, transform.position.y - 20);
		if (testing2.coins == true)
		{
			//Debug.Log("YES");
			
			if (controlCoin < 5)
			{
				transform.position = Vector2.Lerp(transform.position, posA3, Time.deltaTime);
				controlCoin++;
			}
			else if(controlCoin < 10)
			{
				transform.position = Vector2.Lerp(transform.position, posB3, Time.deltaTime);
				controlCoin++;
			}
			else if(controlCoin == 10)
			{
				controlCoin = 0;
				testing2.coins = false;
				Destroy(this.gameObject);
			}
			
			
			
			
		}
	}
}
