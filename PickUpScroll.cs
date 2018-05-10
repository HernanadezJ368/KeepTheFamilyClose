using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpScroll : MonoBehaviour {
	public static bool pickup = false;
	public Text counter;
	public bool triggered = false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		counter.text = "Scrolls: " + GameManager.scrollcount.ToString ();
		if (triggered) {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter(){
		triggered = true;
		GameManager.scrollcount += 1;
		pickup = true;
		GameObject.Find ("Image").GetComponent<Image> ().enabled = true;
		GameObject.Find ("Text").GetComponent<Text> ().enabled = true;
	}
}
