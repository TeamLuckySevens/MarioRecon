using UnityEngine;
using System.Collections;

public class contactCheck : MonoBehaviour {

    ChildScript testing;
    public float move = 0.5f;
    private Vector2 posA;
    private Vector2 posB;
    public int control = 0;
	// Use this for initialization
	void Start () {
		
		testing = gameObject.GetComponentInChildren<ChildScript> ();
        
    }


	
	// Update is called once per frame
	void FixedUpdate () 
	{
        
        posA = new Vector2(transform.position.x, transform.position.y + 2);
        posB = new Vector2(transform.position.x, transform.position.y - 2);
        if (testing.testValue == true)
        {
            //Debug.Log("YES");

            if (control < 5)
            {
                transform.position = Vector2.Lerp(transform.position, posA, Time.deltaTime);
                control++;
            }
            else if(control < 10)
            {
                transform.position = Vector2.Lerp(transform.position, posB, Time.deltaTime);
                control++;
            }
            else if(control == 10)
            {
                control = 0;
                testing.testValue = false;
            }
            

            //transform.position = Vector2.Lerp(startPoint, lerpPos.position, Mathf.PingPong(Time.time * move, 1.0f));
            
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

    }




}
