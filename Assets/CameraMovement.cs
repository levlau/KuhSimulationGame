using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform plane;
    [SerializeField] Vector3 offset;

    [SerializeField] float minZAenderung;
    [SerializeField] float maxZAenderung;

    float zAenderung = 0f;

    [SerializeField] float camMovementSpeed;
    float horizontal;
    float vertical;

    Vector3 move;

    private void Start()
    {
        transform.position = offset;

        minZAenderung *= camMovementSpeed;
        maxZAenderung *= camMovementSpeed;
    }

    /*
    private void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        move = new Vector3(horizontal * Time.deltaTime, 0f, vertical * 0.9f * Time.deltaTime) * camMovementSpeed;

        transform.SetPositionAndRotation(transform.localPosition + move, transform.rotation);

        transform.Translate(move * camMovementSpeed);
        transform.LookAt(plane);
    }*/

    private void Update()
    {
        if (zAenderung < maxZAenderung && Input.GetKey(KeyCode.W))
        {
            vertical = camMovementSpeed;
        }
        else if (zAenderung > minZAenderung && Input.GetKey(KeyCode.S))
        {
            vertical = -camMovementSpeed;
        }
        else
        {
            vertical = 0f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            horizontal = -camMovementSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontal = camMovementSpeed;
        }
        else
        {
            horizontal = 0f;
        }

        move = new Vector3(horizontal, 0f, vertical);

        zAenderung += move.z;

        transform.Translate(move * Time.deltaTime);
        transform.LookAt(plane);
    }
}
