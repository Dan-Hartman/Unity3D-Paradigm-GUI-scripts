using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Data {
	public Text velo;
	public float velocity;
}

public class UpdateVelocity : MonoBehaviour {
	Data dataToUpdate = new Data(); 

	// Use this for initialization
	void Start () {
		GameObject thePod = GameObject.Find ("Pod");
		dataToUpdate.velo = GetComponent<Text> ();
		TelemetryData telemData = thePod.GetComponent<TelemetryData> ();
		dataToUpdate.velocity = telemData.velocity_x;
		InvokeRepeating ("updateData", 1f, 0.3f);
	}

	void updateData() {
		GameObject thePod = GameObject.Find ("Pod");
		TelemetryData telemData = thePod.GetComponent<TelemetryData> ();
		dataToUpdate.velocity = telemData.velocity_x;
		Debug.Log ("Velocity: " + dataToUpdate.velocity);
	}

	// Update is called once per frame
	void Update () {
		dataToUpdate.velo.text = dataToUpdate.velocity.ToString();
	}
}
