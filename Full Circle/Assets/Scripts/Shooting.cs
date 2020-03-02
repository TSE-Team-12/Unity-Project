using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float timer = 25;
    public int ammo = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddAmmo(int ToAdd)
    {
        ammo += ToAdd;
    }

    void Shoot()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        ammo--;
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
