using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float timer = 25; // limits how often they can shoot
    public static int ammo = 10;//gets saved to the class so it continues to next scene
    public bool freeze = false;
    private GameObject lightObject;
    private Light lightComponent;
    private bool muzzleF;

    public void AddAmmo(int ToAdd)
    {
        ammo += ToAdd;//adds to the ammount of ammo the player has
    }

    void Start() {
        lightObject = GameObject.FindGameObjectWithTag("gun");
        lightComponent = lightObject.GetComponent<Light>();
        muzzleF = false;
    }

    void Shoot()
    {
        if (!freeze)
        {//makes it so if you are paused you can't shoot
            Instantiate(bullet, transform.position, transform.rotation);
            ammo--;
            lightComponent.enabled = !lightComponent.enabled;
            muzzleF = true;

        }

    }

    // Update is called once per frame
    void Update()
    {
        // if the timer has pased and the player has ammo they can shoot
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
        if (timer >= 5 && muzzleF) {
            lightComponent.enabled = !lightComponent.enabled;
            muzzleF = false;
        }
    }
}
