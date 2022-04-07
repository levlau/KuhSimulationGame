using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] Transform rotatePoint;
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
    }

    private void Update()
    {
        if (zAenderung < maxZAenderung && Input.GetKey(KeyCode.W))
        {
            vertical = camMovementSpeed * Time.deltaTime;
        }
        else if (zAenderung > minZAenderung && Input.GetKey(KeyCode.S))
        {
            vertical = -camMovementSpeed * Time.deltaTime;
        }
        else
        {
            vertical = 0f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            horizontal = -camMovementSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontal = camMovementSpeed * Time.deltaTime;
        }
        else
        {
            horizontal = 0f;
        }

        move = new Vector3(horizontal, 0f, vertical);

        zAenderung += move.z;

        transform.Translate(move);
        transform.LookAt(rotatePoint.position);
    }
}
