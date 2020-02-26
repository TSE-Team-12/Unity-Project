using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f; //Transition pause time

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LoadNextLevel();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        LoadNextLevel();
    }


    public void LoadNextLevel()//custom function to transition to the next level.
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1)); //takes the current level and transition to the next index via the build order index.
    }

    IEnumerator LoadLevel(int levelIndex) //co-routine
    {
        //Play Transition Animation
        transition.SetTrigger("Start");
        //Wait for Animation to Finish
        yield return new WaitForSeconds(transitionTime);
        //Load the new Scene
        SceneManager.LoadScene(levelIndex); 
    }
}
