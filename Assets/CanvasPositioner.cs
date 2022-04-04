using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPositioner : MonoBehaviour
{
    Vector3 position;
    Quaternion rotation;
    GameObject cow;
    Camera mainCam;

    public void Constructor(GameObject clickedCow)
    {
        cow = clickedCow;
        position = cow.transform.position;
        mainCam = Camera.main;
    }

    private void Update()
    {
        transform.position = position;
        transform.rotation = rotation;
    }
}
