using UnityEngine;

public class RotatePointMove : MonoBehaviour
{
    [SerializeField] Transform ground;
    [SerializeField] float movementSpeed;

    Vector3 max;
    Vector3 min;

    Vector3 pos;
    Vector3 move;

    float horizontal;
    float vertical;

    private void Start()
    {
        //max = new Vector3(ground.localScale.x / 2f, 0f, ground.localScale.z / 2f);
        max = new Vector3(ground.localScale.x, 0f, ground.localScale.z);
        min = max * -1f;
    }

    private void Update()
    {
        pos = transform.position;

        if (pos.z < max.z && Input.GetKey(KeyCode.UpArrow))
        {
            vertical = Input.GetAxis("Vertical") * Time.deltaTime;
        }
        else if (pos.z > min.z && Input.GetKey(KeyCode.DownArrow))
        {
            vertical = Input.GetAxis("Vertical") * Time.deltaTime;
        }
        else
        {
            vertical = 0f;
        }

        if (pos.x > min.x && Input.GetKey(KeyCode.LeftArrow))
        {
            horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        }
        else if (pos.x < max.x && Input.GetKey(KeyCode.RightArrow))
        {
            horizontal = Input.GetAxis("Horizontal") * Time.deltaTime;
        }
        else
        {
            horizontal = 0f;
        }

        move = new Vector3(horizontal, 0f, vertical) * movementSpeed;

        transform.Translate(move);
    }
}
