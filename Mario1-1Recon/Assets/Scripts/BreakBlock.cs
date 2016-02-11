using UnityEngine;
using System.Collections;

public class BreakBlock : MonoBehaviour {

	//public float opposingForce = -950f;


	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "HeadCheck" )
		{
			Debug.Log ("PLAYER HIT");
			Destroy(this.gameObject);
			//other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, opposingForce));
		}
	}
}
