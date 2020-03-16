using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialTextChanger : MonoBehaviour
{
    public Text Tutorial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Tutorial_Movement")
        {
            Tutorial.text = "To move use w,a,s,d or the arrow keys";
        }
        else if (other.name == "Tutorial_Shooting")
        {
            Tutorial.text = "To shoot click the mouse,\nyour bullets will bounce off of the walls";
        }
        else if (other.name == "Tutorial_Pickups")
        {
            Tutorial.text = "These objects are Pick-ups\n" +
                "the yellow ones refill your battery for your torch\n" +
                "the green ones restore 20 health\n" +
                "the red ones restore 10 ammo";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        Tutorial.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
