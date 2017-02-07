using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class npcsText : MonoBehaviour {

	public GameObject textStuff;
	TextMesh npcText; 

	// Use this for initialization
	void Start () {
		textStuff.SetActive (false);
		npcText = textStuff.GetComponent<TextMesh> ();
		npcText.text = "Hello? Anybody there?";
		npcText.text = "pls";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayerCancel () {
		textStuff.SetActive (false);
	}

	public void TalkToPlayer () {
		textStuff.SetActive (true);
		// SET TEXT HERE
		//as an array
	}
}
