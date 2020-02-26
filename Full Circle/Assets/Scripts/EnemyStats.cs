using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float MaxHealth = 100; // Enemy Max Health
    public float CurHealth; // Enemy Current Health

    public void TakeDamage(float Amount) // Take damage function (called by bullet)
    {
        CurHealth -= Amount; // Take 25 damage from current health
    }

    // Start is called before the first frame update
    void Start()
    {
        CurHealth = MaxHealth; // Set current health to Max Health, on start
    }

    // Update is called once per frame
    void Update()
    {
        if (CurHealth <= 0) // If current health goes below 0
        {
            Destroy(this.gameObject, 0f); // Destroy enemy
        }
    }
}
