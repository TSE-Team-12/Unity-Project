using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        PlayerHealth.CurHealth = 100;
        Shooting.ammo = 10;
        TorchScript.range = 100;
        SceneManager.LoadScene("First Level");
    }

    public void PlayTutorial ()
    {
        PlayerHealth.CurHealth = 100;
        Shooting.ammo = 10;
        TorchScript.range = 100;
        SceneManager.LoadScene("Tutorial Level");
    }

    public void ExitGame ()
    {
        Application.Quit();
    }
}
