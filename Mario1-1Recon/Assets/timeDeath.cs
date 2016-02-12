using UnityEngine;
using System.Collections;

public class timeDeath : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		
	}


	private void OnTriggerEnter2D(Collider2D other)
	{
		StartCoroutine(kill());


	}



	IEnumerator kill (){
		
		yield return new WaitForSeconds (.2f);
		Destroy (this.gameObject);
	}
}
