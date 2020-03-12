using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static int CurHealth =100;

    // Update is called once per frame
    void Update()
    {
        if (CurHealth <= 0)
        {//destroys object if the player has less than 0 health
            Destroy(this.gameObject);
        }
    }
}
