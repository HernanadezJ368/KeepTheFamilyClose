using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	public Image test;
	public Text continuetext;
	public Image thesign;
	public Image thesign2;
	public static int scrollcount;
	public static int audiocount;
	void Start () {
		test.enabled = false; 
		continuetext.enabled = false;
		thesign.enabled = false;
		thesign2.enabled = false;
		scrollcount = 0;
		audiocount = 0;

	}
	
	// Update is called once per frame
	void Update () {
		if (PickUpScroll.pickup == true) {
			if (Input.GetKeyDown ("o")) {
				test.enabled = false; 
				continuetext.enabled = false;
			}
		}
	}
}
