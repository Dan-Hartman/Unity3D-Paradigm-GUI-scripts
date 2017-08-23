using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataVel {
	public Text velo;
	public float velocity;
}

public class UpdateVelocity : MonoBehaviour {
	DataVel dataToUpdate = new DataVel(); 

	// Use this for initialization
	void Start () {
		GameObject thePod = GameObject.Find ("Pod");
		dataToUpdate.velo = GetComponent<Text> ();
		dataToUpdate.velocity = Telemetry.dataInstance.timestamp;
		InvokeRepeating ("updateData", 1f, 0.3f);
	}

	void updateData() {
		GameObject thePod = GameObject.Find ("Pod");
		dataToUpdate.velocity = Telemetry.dataInstance.timestamp ;
		Debug.Log ("Velocity: " + dataToUpdate.velocity);
	}

	// Update is called once per frame
	void Update () {
		dataToUpdate.velo.text = dataToUpdate.velocity.ToString();
	}
}
