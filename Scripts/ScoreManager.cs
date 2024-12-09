using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text finalScoreText;
    public TMP_Text winFinalScoreText;  
    public int score;   

    public HealthManager healthManager;   

    private void Start()
    {
        score = 0;        
    }

    public void AddScore(int points)
    {
        score += points * healthManager.currentHealth;
        Switch(SceneManager.GetActiveScene().name);
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
        finalScoreText.text = "" + score;
        winFinalScoreText.text = "" + score;        
    }

    void Switch(string sceneName)
    {
        switch (sceneName)
        {
            case "Level1":
                PlayerPrefs.SetInt("totalScore1", score);               
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level2":
                PlayerPrefs.SetInt("totalScore2", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level3":
                PlayerPrefs.SetInt("totalScore3", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score) + PlayerPrefs.GetInt("totalScore3", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level4":
                PlayerPrefs.SetInt("totalScore4", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score) + PlayerPrefs.GetInt("totalScore3", score) + PlayerPrefs.GetInt("totalScore4", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level5":
                PlayerPrefs.SetInt("totalScore5", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score) + PlayerPrefs.GetInt("totalScore3", score) + PlayerPrefs.GetInt("totalScore4", score) + PlayerPrefs.GetInt("totalScore5", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level6":
                PlayerPrefs.SetInt("totalScore6", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score) + PlayerPrefs.GetInt("totalScore3", score)
                    + PlayerPrefs.GetInt("totalScore4", score) + PlayerPrefs.GetInt("totalScore5", score) + PlayerPrefs.GetInt("totalScore6", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level7":
                PlayerPrefs.SetInt("totalScore7", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score) + PlayerPrefs.GetInt("totalScore3", score)
                    + PlayerPrefs.GetInt("totalScore4", score) + PlayerPrefs.GetInt("totalScore5", score) + PlayerPrefs.GetInt("totalScore6", score) + PlayerPrefs.GetInt("totalScore7", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level8":
                PlayerPrefs.SetInt("totalScore8", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score) + PlayerPrefs.GetInt("totalScore3", score)
                    + PlayerPrefs.GetInt("totalScore4", score) + PlayerPrefs.GetInt("totalScore5", score) + PlayerPrefs.GetInt("totalScore6", score) + PlayerPrefs.GetInt("totalScore7", score)
                    + PlayerPrefs.GetInt("totalScore8", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level9":
                PlayerPrefs.SetInt("totalScore9", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score) + PlayerPrefs.GetInt("totalScore3", score)
                    + PlayerPrefs.GetInt("totalScore4", score) + PlayerPrefs.GetInt("totalScore5", score) + PlayerPrefs.GetInt("totalScore6", score) + PlayerPrefs.GetInt("totalScore7", score)
                    + PlayerPrefs.GetInt("totalScore8", score) + PlayerPrefs.GetInt("totalScore9", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level10":
                PlayerPrefs.SetInt("totalScore10", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score) + PlayerPrefs.GetInt("totalScore3", score)
                    + PlayerPrefs.GetInt("totalScore4", score) + PlayerPrefs.GetInt("totalScore5", score) + PlayerPrefs.GetInt("totalScore6", score) + PlayerPrefs.GetInt("totalScore7", score)
                    + PlayerPrefs.GetInt("totalScore8", score) + PlayerPrefs.GetInt("totalScore9", score) + PlayerPrefs.GetInt("totalScore10", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level11":
                PlayerPrefs.SetInt("totalScore11", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score) + PlayerPrefs.GetInt("totalScore3", score)
                    + PlayerPrefs.GetInt("totalScore4", score) + PlayerPrefs.GetInt("totalScore5", score) + PlayerPrefs.GetInt("totalScore6", score) + PlayerPrefs.GetInt("totalScore7", score)
                    + PlayerPrefs.GetInt("totalScore8", score) + PlayerPrefs.GetInt("totalScore9", score) + PlayerPrefs.GetInt("totalScore10", score) + PlayerPrefs.GetInt("totalScore11", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
            case "Level12":
                PlayerPrefs.SetInt("totalScore12", score);
                PlayerPrefs.SetInt("sumResult", PlayerPrefs.GetInt("totalScore1", score) + PlayerPrefs.GetInt("totalScore2", score) + PlayerPrefs.GetInt("totalScore3", score)
                    + PlayerPrefs.GetInt("totalScore4", score) + PlayerPrefs.GetInt("totalScore5", score) + PlayerPrefs.GetInt("totalScore6", score) + PlayerPrefs.GetInt("totalScore7", score)
                    + PlayerPrefs.GetInt("totalScore8", score) + PlayerPrefs.GetInt("totalScore9", score) + PlayerPrefs.GetInt("totalScore10", score) + PlayerPrefs.GetInt("totalScore11", score)
                    + PlayerPrefs.GetInt("totalScore12", score));
                PlayerPrefs.SetString("time", System.DateTime.Now.ToString("dd.MM.yy HH:mm"));
                PlayerPrefs.Save();
                break;
        }
    }
}
