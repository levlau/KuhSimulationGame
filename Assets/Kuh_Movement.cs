using System.Collections;
using System.Collections.Generic;
using DefinedVariables;
using UnityEngine;

public class Kuh_Movement : MonoBehaviour
{
    float startTime;
    float waitTime;

    [SerializeField] GameObject ground;
     
    [SerializeField] float movementSpeed;

    [SerializeField] float minWaitTime;
    [SerializeField] float maxWaitTime;

    bool moving;

    private void Update()
    {
        if (!moving)
        {
            waitTime = Random.Range(minWaitTime, maxWaitTime);
            startTime = Time.time;

            if (Time.time >= startTime + waitTime)
            {
                SearchPosition();
            }
        }
        
    }

    private void SearchPosition()
    {
        List<Vector3> possiblePositions = new List<Vector3>();
        MovementField m = ground.GetComponent<MovementField>();

        for(int x = 0; x < m.lengthCount; x++)      //mögliche felder adden
        {
            for (int z = 0; z < m.lengthCount; z++)
            {
                if(!m.CheckPosition(new Point(x, z)))
                {
                    possiblePositions.Add(m.GetPosition(new Point(x, z)));
                }
            }
        }

        //TODO: random position aussuchen und MoveToPoint();
        Vector3 position = possiblePositions[Random.Range(0,possiblePositions.Count-1)];
        MoveToPoint(position);
        //m.MoveToPosition(position);   //TODO
    }

    private void MoveToPoint(Vector3 pos)
    {
        moving = true;

        transform.LookAt(pos);

        while(transform.position != pos)
        {
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
    }
}
