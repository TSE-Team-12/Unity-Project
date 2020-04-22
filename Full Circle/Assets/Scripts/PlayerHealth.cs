using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static float CurHealth = 100;
    public GameObject GOText;
    public GameObject TakeDamageUI;
    bool TakenDamage;
    float count = 0;

    // Update is called once per frame

    public void TakeDamage(float Damage)
    {
        PlayerHealth.CurHealth -= Damage;
        TakenDamage = true;
    }

    void Update()
    {
        if (count <= 5)
        {
            if (TakenDamage)
            {
                TakeDamageUI.SetActive(true);

                TakenDamage = false;
            }
            count++;
        }
        else if (count > 5)
        {
            TakeDamageUI.SetActive(false);
            count = 0;
        }

        if (PlayerHealth.CurHealth <= 0)
        {//destroys object if the player has less than 0 health
            GOText.SetActive(true);


            Destroy(this.gameObject);
        }
    }
}
