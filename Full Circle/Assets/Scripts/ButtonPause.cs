using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPause : MonoBehaviour
{
    public GameObject Torch;
    public GameObject Gun;
    //the ButtonPauseMenu
    public GameObject ingameMenu;

    public void OnPause()//点击“暂停”时执行此方法
    {
        Time.timeScale = 0;
        ingameMenu.SetActive(true);
        Torch.GetComponent<TorchScript>().freeze = true;//stops the torch from being lowered while paused
        Gun.GetComponent<Shooting>().freeze = true;//makes it so the player doesn't shoot when they unpause
    }

    public void OnResume()//点击“回到游戏”时执行此方法
    {
        Time.timeScale = 1f;
        ingameMenu.SetActive(false);
        Torch.GetComponent<TorchScript>().freeze = false;//resumes torch reduction
        Gun.GetComponent<Shooting>().freeze = false;// allows player to shoot again
    }

    public void OnExit()//点击“重新开始”时执行此方法
    {
        
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuNew");//goes to menu scene (scene 0)
        Time.timeScale = 1f;
    }

    private void Update()
    {//if p key gets pressed then pause the game
        if (Input.GetKeyDown("p"))
        {
            OnPause();
        }
    }
}
