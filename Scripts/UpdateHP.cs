using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DataHP {
	public Text hp;
	public float highPressure;
}

public class UpdateHP : MonoBehaviour {
	DataHP dataToUpdate = new DataHP(); 

	// Use this for initialization
	void Start () {
		GameObject thePod = GameObject.Find ("Pod");
		dataToUpdate.hp = GetComponent<Text> ();
		TelemetryData telemData = thePod.GetComponent<TelemetryData> ();
		dataToUpdate.highPressure = telemData.hp_pressure;
		InvokeRepeating ("updateData", 1f, 0.3f);
	}

	void updateData() {
		GameObject thePod = GameObject.Find ("Pod");
		TelemetryData telemData = thePod.GetComponent<TelemetryData> ();
		dataToUpdate.highPressure = telemData.hp_pressure;
		Debug.Log ("HP: " + dataToUpdate.highPressure);
	}

	// Update is called once per frame
	void Update () {
		dataToUpdate.hp.text = dataToUpdate.highPressure.ToString();
	}
}
