using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	public Vector2 death;
	public Vector2 left;
	public float speed = 3f;
	public bool hit = false;




	
	// Update is called once per frame
	void Update () {
	
		if (hit == false)
		transform.position = Vector2.MoveTowards (transform.position, death, speed * Time.deltaTime);

		if( hit == true)
			transform.position = Vector2.MoveTowards (transform.position, left, speed * Time.deltaTime);

	}

	private void OnTriggerEnter2D(Collider2D other)
	{



		if (other.tag == "Player")
		{

			if (other.name == "GroundCheck") {
				Destroy (this.gameObject);
			} 
			else {
				Debug.Log ("PLAYER HIT");
				Application.LoadLevel (Application.loadedLevel);
			}
		}
		if (other.tag == "Block") {
			hit =! hit;
		}


		if (other.tag == "wall" || other.tag == "deadzone")
			Destroy (this.gameObject);
	}
}
