using UnityEngine;
using System.Collections;

public class ChildScript : MonoBehaviour {

    public bool testValue = false;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            testValue = true;
        }
        
    }

}
