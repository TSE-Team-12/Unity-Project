using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;
    public float timer = 25;
    public static int ammo = 10;

    public void AddAmmo(int ToAdd)
    {
        ammo += ToAdd;
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
            if (ammo >= 1)
            {
                if (Input.GetMouseButton(0))
                {
                    Shoot();
                    timer = 0;
                }

            }
        }
        else
        {
            timer++;
        }
    }
}
