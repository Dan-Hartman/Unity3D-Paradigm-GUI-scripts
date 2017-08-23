using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataAccel {
	public Text accel;
	public float acceleration;
}

public class UpdateAcceleration : MonoBehaviour {
	DataAccel dataToUpdate = new DataAccel(); 

	// Use this for initialization
	void Start () {
		dataToUpdate.accel = GetComponent<Text> ();
		dataToUpdate.acceleration = Telemetry.dataInstance.acceleration_x;
		InvokeRepeating ("updateData", 1f, 0.3f);
	}

	void updateData() {
		dataToUpdate.acceleration = Telemetry.dataInstance.acceleration_x ;
		Debug.Log ("Acceleration: " + dataToUpdate.acceleration);
	}

	// Update is called once per frame
	void Update () {
		dataToUpdate.accel.text = dataToUpdate.acceleration.ToString();
	}
}
