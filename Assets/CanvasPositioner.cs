using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPositioner : MonoBehaviour
{
    Vector3 position;

    [SerializeField] Vector3 cowPosOffset;
    Vector3 mainCameraPos;
    GameObject cow;

    public void Constructor(GameObject clickedCow)
    {
        cow = clickedCow;
    }

    private void Update()
    {
        mainCameraPos = Camera.main.transform.position;
        position = cow.transform.position + cowPosOffset;

        transform.LookAt(mainCameraPos);
        transform.position = position;

        if (Input.GetMouseButtonDown(1))
        {
            Destroy(gameObject);
        }
    }
}
