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
            Tutorial.text = "To shoot click the mouse,\n" +
                "your bullets will bounce off of the walls\n" +
                "there is an enemy you can practice shooting";
        }
        else if (other.name == "Tutorial_Pickups")
        {
            Tutorial.text = "These objects are Pick-ups\n" +
                "the yellow ones refill your battery for your torch\n" +
                "the green ones restore 20 health\n" +
                "the red ones restore 10 ammo";
        }
        else if (other.name == "Tutorial_Flashlight")
        {
            Tutorial.text = "the flashlight will make it easier to see however\n" +
                " its power will decrease over time\n" +
                "to save battery right click to turn it off";
        }
        else if (other.name == "Tutorial_Pause")
        {
            Tutorial.text = "If you need to take a break you can use 'p' to pause\n" +
                "an alternative is to expand the mini-map by using 'm'";
        }
        else if (other.name == "Tutorial_Lift")
        {
            Tutorial.text = "Every level has a lift to move onto the next level\n" +
                "you have to step inside to activate the lift";
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
