#pragma strict
// Two cameras
var firstPersonCamera: Camera;
var overheadCamera: Camera;

function Start() {
    firstPersonCamera.enabled = false;
    overheadCamera.enabled = true;
}

function Update() {
    if (Input.GetKeyDown("1")) {
        ShowFirstPersonView();
    }
    if (Input.GetKeyDown("2")) {
        ShowOverheadView();
    }
}

// Swap to the overhead pov
function ShowOverheadView() {
    firstPersonCamera.enabled = false;
    overheadCamera.enabled = true;
}

// Swap to the first person pov
function ShowFirstPersonView() {
    firstPersonCamera.enabled = true;
    overheadCamera.enabled = false;
}