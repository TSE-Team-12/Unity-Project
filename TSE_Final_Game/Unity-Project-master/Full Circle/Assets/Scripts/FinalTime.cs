using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTime : MonoBehaviour
{
    public Text TimeCompleted;
    // Start is called before the first frame update
    void Start()
    {
        TimeCompleted.text = "Your time: " + NextLevel.FinishedTime; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
