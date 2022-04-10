using UnityEngine;
using DefinedVariables;

public class MovementField : MonoBehaviour
{
    [SerializeField] GameObject cube;
    [SerializeField] float fencePadding;
    [SerializeField] public int lengthCount;
    [SerializeField] float yOffset;

    Vector3[,] positions;
    bool[,] b_positions;

    private void Start()
    {
        positions = new Vector3[lengthCount, lengthCount];
        b_positions = new bool[lengthCount, lengthCount];

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
                positions[x, z] = pos;
                pos.z += offset;
            }
            pos.z = startZPos;
            pos.x += offset;
        }
    }


    public Vector3 GetPosition(Point position)
    {
        return positions[position.x, position.y];
    }

    public bool CheckPosition(Point position)
    {
        return b_positions[position.x, position.y];
    }

    public void MoveToPosition(Point lastPos, Point newPos)  
    {
        b_positions[lastPos.x, lastPos.y] = false;
        b_positions[newPos.x, newPos.y] = true;
    }
}
