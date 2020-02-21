using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float timer = 25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 25)
        {
            if (Input.GetMouseButton(0))
            {
                Shoot();
                timer = 0;
            }
        } else
        {
            timer++;
        }
        
    }
}
