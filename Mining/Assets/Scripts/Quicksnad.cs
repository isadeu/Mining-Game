using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quicksnad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		


	}
	void OnCollisionEnter2D (Collision2D thingthatHitMe)
	{
		transform.position += new Vector3 (0, 2f, 0); //jump
		//thingthatHitMe.gameObject.GetComponent<Rigidbody2D> ().AddForce (Vector2.left * -9, ForceMode2D.Impulse);
		//thingthatHitMe.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (*-3,0), ForceMode2D.Impulse);
		//this is what im having trouble with ^ 
	}
}
