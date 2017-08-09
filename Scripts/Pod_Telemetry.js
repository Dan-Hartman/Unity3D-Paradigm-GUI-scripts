#pragma strict
// Get the latest pod telemetry data from localhost:7777/state
public var url: String = "http://localhost:7777/state";
public var json: String;
public var velocity: int;

function Start () {
	var wwwInitial: WWW = new WWW(url);
    var renderer: Renderer = GetComponent.<Renderer>();
    if (wwwInitial.isDone) {
    	json = wwwInitial.text;
    	Debug.Log("Data retrieved: " + json);
	   	InvokeRepeating("updateJson", 0.01, 2.0);
    }
}

function updateJson() {
	var wwwUpdated: WWW = new WWW(url);
	if (wwwUpdated.isDone) {
		json = wwwUpdated.text;
		Debug.Log("Data updated to: " + json);
	}
}

function Update () {
	for (var child : Transform in transform) {
		if (child.position.z > 90) {
	    child.position -= Vector3.forward * velocity / 140;
	    }
	}
}
