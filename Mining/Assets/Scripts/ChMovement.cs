using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.position += new Vector3 (.1f, 0, 0);//RIGHT position is stored on a vector3
		}

		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.position -= new Vector3 (.1f, 0, 0);//LEFT ^but instead of minus bc its moving right not left
		}
		if (Input.GetKeyDown (KeyCode.UpArrow))
			transform.position += new Vector3 (0, 2f, 0); //jump
	}
}
