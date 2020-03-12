using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangedEnemy : MonoBehaviour
{
    
    Transform player;
    public float attackTimer = 60;
    public float attackDist = 10;
    public GameObject bullet;
    float strayAmount = 10f;
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
            // Enemy Shoots when player is in range //
            if (attackTimer >= 60)
            {
                enemyShoot();
                attackTimer = 0;
            }
        }
        if (attackTimer < 60){
            attackTimer++;
        }
    }

    void enemyShoot() {
        var rndY = Random.Range(-strayAmount, strayAmount);
        var enemyBullet = Instantiate(bullet, transform.position, transform.rotation); 
        //Adds random bullet deviation to make the projectile a little less predictable //
        enemyBullet.transform.Rotate(player.transform.position.x, rndY, player.transform.position.z);
        
    }
}
