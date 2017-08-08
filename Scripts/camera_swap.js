#pragma strict
// Two cameras
var firstPersonCamera: Camera;
var overheadCamera: Camera;

function Start() {
	firstPersonCamera.enabled = true;
	overheadCamera.enabled = false;
}

function Update() {
	if (Input.GetKeyDown("1")) {
        ShowFirstPersonView();
    }
    if (Input.GetKeyDown("2")) {
        ShowOverheadView();
    }
}

function ShowOverheadView() {
    firstPersonCamera.enabled = false;
    overheadCamera.enabled = true;
}

function ShowFirstPersonView() {
    firstPersonCamera.enabled = true;
    overheadCamera.enabled = false;
}
