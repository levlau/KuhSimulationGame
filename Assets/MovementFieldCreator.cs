using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFieldCreator : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] float fencePadding;
    [SerializeField] int lengthCount;
    [SerializeField] float yOffset;


    private void Start()
    {
        float minXPos = transform.localScale.x / 2f;
        float minZPos = transform.localScale.z / 2f;

        float offset = (transform.localScale.x - fencePadding) / lengthCount;

        Vector3 pos = new Vector3(-minXPos + fencePadding, transform.position.y + yOffset, -minZPos + fencePadding);
        float startZPos = pos.z;

        for (int x = 0; x < lengthCount; x++)
        {
            for (int z = 0; z < lengthCount; z++)
            {
                Instantiate(cube, pos, transform.rotation);
                pos.z += offset;
            }
            pos.z = startZPos;
            pos.x += offset;
        }
    }

}
