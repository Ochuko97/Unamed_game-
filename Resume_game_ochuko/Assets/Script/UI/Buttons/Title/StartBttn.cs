using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI; 

public class StartBttn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	} 
	public void Startbtnn () {
		SceneManager.LoadScene ("Tutorial Screen", LoadSceneMode.Single); 
	}
}
