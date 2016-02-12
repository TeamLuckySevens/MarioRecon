using UnityEngine;
using System.Collections;

public class small : MonoBehaviour {

	public Vector2 height;
	public Vector2 startPos;
	public float Speed = 3f;
	public float bumpHeight = .5f;
	SpriteRenderer sr;
	public Sprite used;
	public GameObject prefab;
	int mush;
	private Vector2 itemSpawn;






	private bool bump = false;

	int count = 0;



	void Start(){


		startPos = transform.position;
		height = transform.position;
		height.y += bumpHeight;
		sr = GetComponent<SpriteRenderer> ();
		itemSpawn = height;
		itemSpawn.y += .7f;


	}




	void Update(){

		AudioSource sound = GetComponent<AudioSource> ();

		if(bump == true && count < 1){
			transform.position = Vector3.MoveTowards (transform.position, height , Speed* Time.deltaTime);
			//bump = false;
			Debug.Log("UP");
			sound.Play ();

		}
		if (transform.position.y == height.y) {
			while (transform.position.y != startPos.y) {
				transform.position = Vector3.MoveTowards (transform.position, startPos, Speed * Time.deltaTime);
				Debug.Log ("DOWN");
				bump = false;
				count++;
				sr.sprite = used;

			}
				
		}
	
	}

	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D col) {

		if (col.name == "HeadCheck") {
			bump = true;
			if (mush < 1)
				Instantiate (prefab, itemSpawn, Quaternion.identity);
				mush += 1;
				
				
		}





	
	}




}
