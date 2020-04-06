﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene("First Level");
    }

    public void PlayTutorial ()
    {
        SceneManager.LoadScene("Tutorial Level");
    }

    public void ExitGame ()
    {
        Application.Quit();
    }
}
