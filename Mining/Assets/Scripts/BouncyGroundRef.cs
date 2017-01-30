using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyGroundRef : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D thingthatHitMe)
	{
		thingthatHitMe.gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0,9f), ForceMode2D.Impulse);//when objects hit this object they move side to side 2 spaces and uo 6
	}
}
