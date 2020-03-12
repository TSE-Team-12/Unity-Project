using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangedEnemy : MonoBehaviour
{
    
    Transform player;
    public float attackTimer = 10;
    public float attackDist = 10;
    public GameObject bullet; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Player distance check before attacking //
        if (Vector3.Distance(transform.position, player.position) < attackDist)
        {
            // Makes the ranged enemy face the player before attacking //
            Vector3 targetPosition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z); //restricts ranged enemy rotation to the y axis.
            transform.LookAt(targetPosition);
        } 
    }

    void enemyShoot() {
        Instantiate(bullet, transform.position, transform.rotation); 
    }
}
