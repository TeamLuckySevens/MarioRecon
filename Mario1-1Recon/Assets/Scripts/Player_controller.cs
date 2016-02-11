using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player_controller : MonoBehaviour {
	
	
	public float maxSpeed = 10f;
	public float currentSpeed = 1f;
	bool facingRight = true;
	private float accleration = 0.25f;
	private float currentHeight = 0f;
	private float maxHeight = 10f;
	private float timeElapsed = 0f;
	
	Animator anim;
	
	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	public float jumpForce = 700f;
	
	bool doubleJump = true;
	
	public Text scoreText;
	public int score;
	private string holder;



	int run = Animator.StringToHash ("moving");
	
	
	
	
	
	
	
	
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	
	void Update ()
	{


		UpdateScore ();
		
		
		if ((grounded || !doubleJump) && Input.GetKeyDown (KeyCode.Space)) {

			GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));

			
			if (!doubleJump && !grounded)
				doubleJump = true;
			
			
		}

		
		
		
		
	}
	
	
	
	
	// Update is called once per frame
	void FixedUpdate () {
		
		
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		
		if (grounded)
			doubleJump = true;
		

		float move = Input.GetAxis ("Horizontal");
		
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * currentSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		//Debug.Log (currentSpeed);
		
		
		
		if(grounded && currentSpeed < maxSpeed && move != 0)
		{
			currentSpeed += accleration;

		}
		else if(move == 0 && currentSpeed > 0)
		{
			currentSpeed--;
		}
		
		
		
		if (move > 0 && !facingRight)
		{
			Flip ();
			if(grounded)
				currentSpeed = 2f;
		}
		else if (move < 0 && facingRight)
		{
			Flip ();
			if(grounded)
				currentSpeed = 2f;
		}




		if (move!=0) {
			anim.SetBool (run, true);
		} 
		else {
			anim.SetBool (run, false);
		}
		
		
	}
	
	
	
	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
	
	
	
	
	void UpdateScore(){
		
		
		
		holder = score.ToString ("D6");
		scoreText.text = holder;
		
	}
	
}
