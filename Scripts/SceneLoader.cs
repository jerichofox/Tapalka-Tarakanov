using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{   

    public void OptionsLoad()
    {
        SceneManager.LoadScene("Options");
    }

    public void ScoreLoad()
    {
        SceneManager.LoadScene("Score");
    }

    public void HelpLoad()
    {
        SceneManager.LoadScene("Help");
    }    

    public void BackButtonLoad()
    {
        SceneManager.LoadScene("MainMenu");
    }    

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Level1Load()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Level2Load()
    {
        SceneManager.LoadScene("Level2");
    }    

    public void ResetScore()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("MainMenu");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 
        
}
