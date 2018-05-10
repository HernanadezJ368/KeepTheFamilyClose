using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignPopUp : MonoBehaviour {

	// Use this for initialization
	//public Image thesign;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		GameObject.Find ("Image(1)").GetComponent<Image> ().enabled = true;
	}
	void OnTriggerExit(){
		GameObject.Find ("Image(1)").GetComponent<Image> ().enabled = false;
	}
}
