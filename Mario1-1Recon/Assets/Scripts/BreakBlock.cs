using UnityEngine;
using System.Collections;

public class BreakBlock : MonoBehaviour {

	//public float opposingForce = -950f;

	Animator anim;

	int brick = Animator.StringToHash ("Break");


	void Start (){
		anim = GetComponent<Animator> ();

	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "HeadCheck" && GameObject.Find("Mario").GetComponent<Player_controller>().isSuper == true )
		{
			Debug.Log ("PLAYER HIT");
			anim.SetBool (brick, true);
			Destroy(this.gameObject);
			//other.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, opposingForce));
		}
	}
}
