﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rangedEnemy : MonoBehaviour
{
    
    Transform player;
    private float attackTimer = 60;
    public float attackDist = 10;
    public GameObject enemyBullet;
    float strayAmount = 10f;
    private GameObject lightObj;
    private Light lightComp;
    private bool muzzleF;
   
    void Start()
    {
        muzzleF = false;
        lightComp = GetComponentInChildren<Light>();
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
        if (attackTimer >= 5 && muzzleF) {
            muzzleF = false;
            lightComp.enabled = !lightComp.enabled;
        }
    } 

    void enemyShoot() {
        var rndY = Random.Range(-strayAmount, strayAmount);
        Quaternion Angle = Quaternion.Euler(player.transform.position.x,transform.position.y + rndY, player.transform.position.z) ;
        
        Instantiate(enemyBullet, transform.position,transform.rotation);
        lightComp.enabled = !lightComp.enabled;
        muzzleF = true;
        //Adds random bullet deviation to make the projectile a little less predictable //
        
        
    }
}
