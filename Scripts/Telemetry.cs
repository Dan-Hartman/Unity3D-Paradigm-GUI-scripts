using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Represents important information that is to be accsessed and
// used for real time visual representation. 
[System.Serializable]
public class TelemetryData {
	public float position_x;
	public float velocity_x;
	public float acceleration_x;
	public float hp_pressure;
}

public class Telemetry : MonoBehaviour {
	string jsonString;
	string url = "http://localhost:7777/state";
	TelemetryData dataInstance = new TelemetryData();

	// Use this for initialization
	void Start () {
		InvokeRepeating ("updateJson", 0.5f, 0.5f);
	}

	void updateJson() {
		Debug.Log (dataInstance.velocity_x);
		WWW www = new WWW (url);
		StartCoroutine (WaitForRequest (www));
	}

	IEnumerator WaitForRequest(WWW www) {
		yield return www;
		Debug.Log ("Data Retrieved: " + www.text);
		jsonString = www.text;
		deserialize();
	}

	void deserialize() {
		JsonUtility.FromJsonOverwrite (jsonString, dataInstance);
		Debug.Log (dataInstance.velocity_x);
	}

	// Update is called once per frame
	void Update () {
		// Moves all parts of the pod at the same time as
		// there are multiple child objects.
		foreach (Transform child in transform) {
			child.position -= 
				// The value 3.624645024 is a constant that was calculated to 
				// transform real velocity to unity's scaled velocity
				(Vector3.forward * dataInstance.velocity_x / (float)3.624645024);
		}
	}
}