﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletBehaviour : MonoBehaviour
{
    public LayerMask collisionmask; // Used to check bullet hits
    public float Speed = 5;
    public float Damage = 10;
    AudioSource audioSource;
    public AudioClip gunShot;
    public AudioClip bulletCasing;
    PlayerHealth Playerhealth;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);   // Destroys the bullet after 5 seconds
        GameObject gun = GameObject.FindGameObjectWithTag("gun");
        audioSource = gun.GetComponent<AudioSource>();
        audioSource.pitch = (Random.Range(0.6f, .9f));
        audioSource.PlayOneShot(gunShot, 0.3F);
        audioSource.pitch = (Random.Range(0.8f, 1));
        audioSource.PlayOneShot(bulletCasing, 0.2f);//changes sounds pitch on bullet creation
        Playerhealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed); // Moves the bullet forward, locked to deltaTime

        Ray ray = new Ray(transform.position, transform.forward); // Produces forward line, has no range, stops when hits object
        RaycastHit hit; // On hit, get hit object 
        if (Physics.Raycast(ray, out hit, Time.deltaTime * Speed + 0.5f, collisionmask)) // Check for collision, a small area infront of bullet, to prevent wall glitching
        {

            if (hit.transform.tag == "Player") // Check through tags, if object hit is an enemy
            {
                Playerhealth.TakeDamage(Damage); // Call TakeDamage inside EnemyStats
                Destroy(gameObject); // Destroy bullet
            }
            else if (hit.transform.tag == "Wall") // Check through tags, if object hit is a wall (haha noob)
            {
                Destroy(this.gameObject);
            }
            else // Incase of other events
            {

            }
        }
    }
}
