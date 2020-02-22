using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float MaxHealth = 100;
    public float CurHealth;

    public void TakeDamage(float Amount)
    {
        CurHealth -= 25;
    }

    // Start is called before the first frame update
    void Start()
    {
        CurHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurHealth <= 0)
        {
            Destroy(this.gameObject, 0f);
        }
    }
}
