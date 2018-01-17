#pragma strict

// Three cameras
var firstPersonCamera: Camera;
var overheadCamera: Camera;
var frontCamera: Camera;

// Used to initialize.
function Start() {
	firstPersonCamera.enabled = false;
	frontCamera.enabled = false;
	overheadCamera.enabled = true;
}

// Called every frame.
function Update() {
    if (Input.GetKeyDown("1")) {
        ShowFirstPersonView();
    }
    if (Input.GetKeyDown("2")) {
        ShowOverheadView();
    }
    if (Input.GetKeyDown("3")) {
    	ShowFrontView();
    }
}

// Swap to the overhead pov
function ShowOverheadView() {
    firstPersonCamera.enabled = false;
    frontCamera.enabled = false;
    overheadCamera.enabled = true;
}

// Swap to the first person pov
function ShowFirstPersonView() {
    overheadCamera.enabled = false;
    frontCamera.enabled = false;
    firstPersonCamera.enabled = true;
}

// Swap to the front pod view
function ShowFrontView() {
	firstPersonCamera.enabled = false;
	overheadCamera.enabled = false; 
	frontCamera.enabled = true;
}
