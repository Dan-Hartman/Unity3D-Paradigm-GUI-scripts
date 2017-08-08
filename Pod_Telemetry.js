#pragma strict
// Get the latest pod telemetry data from localhost:7777/state
public var url: String = "http://localhost:7777/state";
public var json: String;
public var time: int;

function Start () {
	var wwwInitial: WWW = new WWW(url);
    var renderer: Renderer = GetComponent.<Renderer>();
    if (wwwInitial.isDone) {
    	json = wwwInitial.text;
    	Debug.Log("Data retrieved: " + json);
    	InvokeRepeating("updateTime", 0.01, 2.0);
    }
//    renderer.material.mainTexture = www.texture;
}

function updateTime() {
	time+=2;
}

function Update () {
	if(time > 0 && time % 2 == 0) {
		StartCoroutine("updateJson");
	}
}

function updateJson() {
	var wwwUpdated: WWW = new WWW(url);
	if (wwwUpdated.isDone) {
		json = wwwUpdated.text;
		Debug.Log("Data updated to: " + json);
	}
}
