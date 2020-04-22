using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapEnlargeToggle : MonoBehaviour
{
    public GameObject Border_Minimap;
    public GameObject MapMini;
    private bool largetoggle = false;
    public GameObject Torch;
    
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            if(largetoggle == false)
            {//if it is small it changes the position and increases the size
                Border_Minimap.GetComponent<RectTransform>().localPosition+= new Vector3(-130,-130,0);
                Border_Minimap.GetComponent<RectTransform>().sizeDelta = new Vector2(356, 356);
                MapMini.GetComponent<RectTransform>().sizeDelta = new Vector2(340, 340);
                largetoggle = true;
                Time.timeScale = 0;//freezes the game
                Torch.GetComponent<TorchScript>().freeze = true;

            }
            else
            {//makes map smaller and moves it back
                Border_Minimap.GetComponent<RectTransform>().position += new Vector3(130, 130, 0);
                Border_Minimap.GetComponent<RectTransform>().sizeDelta = new Vector2(178, 178);
                MapMini.GetComponent<RectTransform>().sizeDelta = new Vector2(170, 170);
                largetoggle = false;
                Time.timeScale = 1f;//resumes game
                Torch.GetComponent<TorchScript>().freeze = false;
            }
        } 

    }
}
