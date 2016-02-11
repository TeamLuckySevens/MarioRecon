using System;
using UnityEngine;



public class FollowTarget : MonoBehaviour
{


	public Camera camera;
	public Transform target;
	public Vector3 offset = new Vector3(0f, 7.5f, 0f);
	float height  = 0f;
	float width;

	void Start() {
		
	}

	private void LateUpdate()
	{


		width = (-camera.pixelWidth / 50);
		offset = new Vector3 (width, height, 0f);

		transform.position = target.position + offset;


		Vector3 screenPos = camera.WorldToScreenPoint(target.position);
		Debug.Log("target is " + screenPos.x + " pixels from the left");



		Debug.Log ("The screen is " + camera.pixelWidth + " wide");
	}
}
