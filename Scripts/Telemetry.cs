using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telemetry : MonoBehaviour {
	string jsonString;
	string url = "http://localhost:7777/state";
	TelemetryData dataInstance = new TelemetryData();

	// Use this for initialization
	void Start () 
	{
		InvokeRepeating ("updateJson", 0.5f, 0.5f);
	}

	void updateJson()
	{
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

	void deserialize() 
	{
		JsonUtility.FromJsonOverwrite (jsonString, dataInstance);
		Debug.Log (dataInstance.velocity_x);
	}

	// Update is called once per frame
	void Update () {
		foreach (Transform child in transform) {
			child.position -= Vector3.forward * (dataInstance.velocity_x / 140);
		}
	}
}

[System.Serializable]
public class TelemetryData 
{
	public int velocity_x;
}