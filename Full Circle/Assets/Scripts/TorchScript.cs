using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{
    public GameObject Torch;
    public static float range = 100;
    int counter = 0;
    private float minRange = 4;

    public bool freeze = false;


    // Start is called before the first frame update
    void Start()
    {
        range = Torch.GetComponent<Light>().range;//gets the torch range
    }


    // Update is called once per frame
    void Update()
    {
        //allows player to turn torch off to save battery
        if (Input.GetMouseButtonDown(1))
        {
            if (!freeze)
            {
                Torch.GetComponent<Light>().range = 0;
                freeze = true;
            }
            else
            {
                Torch.GetComponent<Light>().range = range;
                freeze = false;
            }

        }


        if (!freeze)//stops the torch range from decreasing
        {
            if (range > minRange)
            {
                if (counter >= 50)
                {
                    range--;
                    Torch.GetComponent<Light>().range = range;
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
