using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataPos {
	public Text pos;
	public float position;
}

public class UpdatePosn : MonoBehaviour {
	DataPos dataToUpdate = new DataPos(); 

	// Use this for initialization
	void Start () {
		dataToUpdate.pos = GetComponent<Text> ();
		dataToUpdate.position = Telemetry.dataInstance.position_x;
		InvokeRepeating ("updateData", 1f, 0.3f);
	}

	void updateData() {
		dataToUpdate.position = Telemetry.dataInstance.position_x ;
		Debug.Log ("Position: " + dataToUpdate.position);
	}

	// Update is called once per frame
	void Update () {
		dataToUpdate.pos.text = dataToUpdate.position.ToString();
	}
}
