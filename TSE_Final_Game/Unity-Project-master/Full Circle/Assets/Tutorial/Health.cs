using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static int CurHealth = 100;

    // Update is called once per frame
    void Update()
    {
        if (CurHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
