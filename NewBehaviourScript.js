#pragma strict

function Start () {
	Debug.Log("Testing");
}

function Update () {
	for (var child : Transform in transform) {
		if (child.position.z > 90) {
	    child.position -= Vector3.forward * 1.0;
	    }
	}
}
