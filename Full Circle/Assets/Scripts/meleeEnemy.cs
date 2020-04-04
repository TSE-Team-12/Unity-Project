using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meleeEnemy : MonoBehaviour
{
    
    Transform player;
    public float attackTimer = 60;
    public float detectDist = 10;
    public float Damage = 20;
    float moveSpeed = 3;

   
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // Player distance check before moving//
        if (Vector3.Distance(transform.position, player.position) < detectDist)
        {
            // Makes the ranged enemy face the player before attacking //
            Vector3 targetPosition = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z); //restricts ranged enemy rotation to the y axis.
            transform.LookAt(targetPosition);//enemy face player
            transform.position += transform.forward * moveSpeed * Time.deltaTime;//enemy moves toward player
        }
        if (attackTimer < 60)
        {
            attackTimer++;
        }
    }

    void OnCollisionEnter(Collision collision) { 
        if (collision.gameObject.tag == "Player")
        {
            if (attackTimer >= 60) {
                Debug.Log("collision");
                PlayerHealth.CurHealth -= Damage;
                attackTimer = 0;
            }
        }
    }
}
