using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockAccellerationTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.z > 200) {
			foreach (Transform child in transform) {
				child.position -= 
					(Vector3.forward * 10);
			}
		} else if (transform.position.z > 0 &&
		           transform.position.z < 200) {
			foreach (Transform child in transform) {
				child.position -= 
					(Vector3.forward * 3);
			}
		} else if (transform.position.z < 0) {
			foreach (Transform child in transform) {
				child.position -= 
					(Vector3.forward * 0);
			}
		}
	}
 }
