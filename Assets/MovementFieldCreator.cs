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
        float offset = transform.localScale.x - 2 * fencePadding / lengthCount;

        float xScale = transform.localScale.x * 2f;
        float zScale = transform.localScale.z * 2f;

        Vector3 pos = new Vector3(-xScale + fencePadding, transform.position.y + yOffset, -zScale + fencePadding);
        float startZPos = pos.z;

        for(int x = 0; x < lengthCount; x++)
        {
            for(int z = 0; z < lengthCount; z++)
            {
                Instantiate(cube, pos, transform.rotation);
                pos.z += offset;
            }
            pos.z = startZPos;
            pos.x += offset;
        }
    }
}
