using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour {

	public AudioSource Tet;
	public Text audiotext;
	public bool triggered = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		audiotext.text = "Audio Messages: " + GameManager.audiocount.ToString ();
		if (triggered) {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter(){
		triggered = true;
		GameManager.audiocount += 1;
		Tet.Play();
		//GameObject.Find ("Image").GetComponent<Image> ().enabled = true;
	}
}
