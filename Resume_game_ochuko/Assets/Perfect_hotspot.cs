using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perfect_hotspot : MonoBehaviour {

	void Update () {
		if (Input.GetMouseButtonDown (0)) { 
			Debug.Log ("Clicked");  
			CastRay ();
		} 
	}
	void CastRay() {		
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition); 
		RaycastHit hit;  
		if (Physics.Raycast (ray, out hit, 100)) {
				Debug.DrawLine (ray.origin, hit.point); 
				Debug.Log ("Perfect");
			}
		}
	}