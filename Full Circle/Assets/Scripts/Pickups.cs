using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{

    public Text healthText;
    public Text ammoText;
    public Text batteryText;

    //gets colours to change the text-colour
    public Color High;
    public Color Medium;
    public Color Low;


    private int health;
    private int ammo;
    private float battery;

    void Start()
    {
        //gets starting values for the variables
        health = PlayerHealth.CurHealth;
        ammo = Shooting.ammo;
        battery = TorchScript.range;

    }

    private void Update()
    {
        UpdateHealth();//calls the function every frame to make sure the health,ammo,battery are up to date
        UpdateAmmo();
        UpdateBattery();
    }

    void UpdateHealth()
    {
        health = PlayerHealth.CurHealth;
        healthText.text = "Health: " + health.ToString();
        if (health >= 100)
        {
            healthText.color = High;//sets health colour to green
        }
        else if (health >= 60)
        {
            healthText.color = Medium;
        }
        else
        {
            healthText.color = Low;//sets health to red
        }

    }

    void UpdateAmmo()
    {
        ammo = Shooting.ammo;
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
        battery = TorchScript.range;
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
            //checks for the HealthPickup tag to see if the player has entered the collider of trigger
        {
            other.gameObject.SetActive(false);
            health = PlayerHealth.CurHealth += 20;

        }
        //sets battery back to full 
        if (other.gameObject.CompareTag("BatteryPickup"))
        {
            other.gameObject.SetActive(false);
            battery = TorchScript.range = 100;
        }

        if (other.gameObject.CompareTag("AmmoPickup"))
        {
            other.gameObject.SetActive(false);
            ammo = Shooting.ammo += 10;
        }


    }
}