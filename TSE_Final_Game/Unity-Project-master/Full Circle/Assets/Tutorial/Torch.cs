using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torch : MonoBehaviour
{
    public GameObject torch;
    public static float range = 100;
    int counter = 0;
    private float minRange = 0;
    public bool freeze = false;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (!freeze)
            {
                torch.GetComponent<Light>().range = 0;
                freeze = true;
            }
            else
            {
                torch.GetComponent<Light>().range = range;
                freeze = false;
            }

        }


        if (!freeze)
        {
            if (range > minRange)
            {
                if (counter >= 50)
                {
                    
                    torch.GetComponent<Light>().range = range;
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }

        }

    }
}
