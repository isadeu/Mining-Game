using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChMovement : MonoBehaviour {
	Rigidbody2D rb;
	bool playerInTrigger = false;
	npcsText currentNPC;
	public float movement = .5f;
	public bool jumping = false;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> (); //anythign for the rigidbody
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.AddForce (Vector2.right * movement, ForceMode2D.Impulse);
			//transform.position += new Vector3 (.1f, 0, 0);//RIGHT position is stored on a vector3
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.AddForce (Vector2.left * 1, ForceMode2D.Impulse);
			//transform.position -= new Vector3 (.1f, 0, 0);//LEFT ^but instead of minus bc its moving right not left
		}


		/*if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			//rb.AddForce (Vector2.up * 5, ForceMode2D.Impulse);
		transform.position += new Vector3 (0, 2f, 0); //jump
		}*/




		if (Input.GetKeyDown (KeyCode.A)) { 

			if (playerInTrigger) {
				if (Input.GetKeyDown (KeyCode.A)) {
					currentNPC.PlayerCancel ();
				}
			}
		}
	}

	void Jumping (){
			if (Input.GetKeyDown (KeyCode.UpArrow))
		{
				Jumping = true;
			//rb.AddForce (Vector2.up * 5, ForceMode2D.Impulse);
		transform.position += new Vector3 (0, 2f, 0); //jump
		}
			

	}

	
	void OnTriggerEnter2D (Collider2D p) {
		if (p.gameObject.tag == "floor") {
			jumping = (true);
	
		} 
	}

	void OnTriggerEnter2D (Collider2D c) {
		if (c.gameObject.tag == "npcs") {
			//Debug.Log ("entered trigger");
			currentNPC = c.gameObject.GetComponent<npcsText> ();
			c.gameObject.GetComponent<npcsText> ().TalkToPlayer ();

			playerInTrigger = true;
		}
	}

	void OnTriggerExit2D (Collider2D c) {
		if (c.gameObject.tag == "npcs") {
			playerInTrigger = false;


		}
	}
}
