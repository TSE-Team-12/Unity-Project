using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{

    public Text healthText;            
    public Text ammoText;
    public Text batteryText;

    private int health;
    private int ammo;
    private int battery;

     void Start()
    {

        health = 100;
        ammo = 0;
        battery = 100;

    }

   
    void OnTriggerEnter(Collider other)
    {

        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("HealthPickup"))
        {
            other.gameObject.SetActive(false);
            health = health + 20;
            SetHealthText ();
        }

        if (other.gameObject.CompareTag("BatteryPickup"))
        {
            other.gameObject.SetActive(false);
            battery = battery + 20;
            SetBatteryText();
        }

        if (other.gameObject.CompareTag("AmmoPickup"))
        {
            other.gameObject.SetActive(false);
            ammo = ammo + 5;
            SetAmmoText();
        }

        void SetHealthText()
        {
            healthText.text = "Health: " + health.ToString();
        }
        void SetAmmoText()
        {
            ammoText.text = "Ammo: " + ammo.ToString();
        }
        void SetBatteryText()
        {
            batteryText.text = "Battery: " + battery.ToString();
        }
    }
}