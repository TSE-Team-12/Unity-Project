using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchScript : MonoBehaviour
{
    public GameObject Torch;
    public float range;
    int counter = 0;
    private float minRange = 0;
    // Start is called before the first frame update
    void Start()
    {
        range = Torch.GetComponent<Light>().range;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(range > minRange)
        {
            if (counter == 50)
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
