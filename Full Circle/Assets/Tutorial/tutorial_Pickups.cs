﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorial_Pickups : MonoBehaviour
{

    public Text healthText;
    public Text ammoText;
    public Text batteryText;
    public GameObject gun;
    public GameObject torch;
    public GameObject Player;
    public Color High;
    public Color Medium;
    public Color Low;


    private int health;
    private int ammo;
    private float battery;

    void Start()
    {

        health = Health.CurHealth;
        ammo = Gun.ammo;
        battery = Torch.range;

    }

    private void Update()
    {
        UpdateHealth();
        UpdateAmmo();
        UpdateBattery();
    }

    void UpdateHealth()
    {
        health = Health.CurHealth;
        healthText.text = "Health: " + health.ToString();
        if (health >= 100)
        {
            healthText.color = High;
        }
        else if (health >= 60)
        {
            healthText.color = Medium;
        }
        else
        {
            healthText.color = Low;
        }

    }

    void UpdateAmmo()
    {
        ammo = Gun.ammo;
        ammoText.text = "Ammo: " + ammo.ToString();
        if (ammo >= 10)
        {
            ammoText.color = High;
        }
        else if (ammo >= 5)
        {
            ammoText.color = Medium;
        }
        else
        {
            ammoText.color = Low;
        }
    }

    void UpdateBattery()
    {
        battery = Torch.range;
        batteryText.text = "Battery: " + battery.ToString();
        if (battery >= 66)
        {
            batteryText.color = High;
        }
        else if (battery >= 33)
        {
            batteryText.color = Medium;
        }
        else
        {
            batteryText.color = Low;
        }
    }

    void OnTriggerEnter(Collider other)
    {

        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("HealthPickup"))
        {
            other.gameObject.SetActive(false);
            health = Health.CurHealth += 20;

        }

        if (other.gameObject.CompareTag("BatteryPickup"))
        {
            other.gameObject.SetActive(false);
            battery = Torch.range += 20;
        }

        if (other.gameObject.CompareTag("AmmoPickup"))
        {
            other.gameObject.SetActive(false);
            gun.GetComponent<Gun>().AddAmmo(10);
        }


    }
}