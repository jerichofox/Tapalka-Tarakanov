using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToNextLevel : MonoBehaviour
{
    public int nextSceneLoad;

    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void NextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 16) 
        {
            Debug.Log("You Completed ALL Levels");            
        }
        else
        {            
            SceneManager.LoadScene(nextSceneLoad);
           
            if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextSceneLoad);
            }
        }
    }
}

