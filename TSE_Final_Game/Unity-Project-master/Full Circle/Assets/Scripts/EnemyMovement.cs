using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Transform Player;

    public Transform[] MoveSpot;
    public int SpotCounter = 0;
    float MoveSpeed = 5;
    float DetectRange = 15;
    float minDistance = 2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        if (Vector3.Distance(transform.position, Player.position) <= DetectRange)
        {
            Vector3 targetPosition = new Vector3(Player.transform.position.x, transform.position.y, Player.transform.position.z); //restricts ranged enemy rotation to the y axis.
            transform.LookAt(targetPosition);
            if (Vector3.Distance(transform.position, Player.position) > minDistance)
            {
                transform.position += Vector3.forward * 0;
            } else
            {
                transform.position += Vector3.forward;
            }
            
        }
        else
        {
            if (transform.position == MoveSpot[SpotCounter].position)
            {
                SpotCounter++;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, MoveSpot[SpotCounter].position, MoveSpeed * Time.deltaTime);
            }
        }
        if (SpotCounter > MoveSpot.Length-1)
        {
            SpotCounter = 0;
        }
    }
}
