using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameManager gameManager;
    public TMP_Text timerText; 

    private float elapsedTime = 0f;
    public float targetTime = 10f; // Set your desired time limit here           

    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= targetTime && gameManager.loose == false)
        {            
            timerText.text = "Victory!";            
            gameManager.WinStartGameOverSequences();
            timerText.text = "";
        }
        else
        {
            float remainingSeconds = targetTime - elapsedTime;            
            int minutes = (int)(remainingSeconds % 3600 / 60);
            int seconds = (int)(remainingSeconds % 60);
            double milliseconds = (remainingSeconds - Mathf.Floor(remainingSeconds)) * 1000;

            timerText.text = $"{minutes:00}:{seconds:00}.{milliseconds:000}";
        }
    }  
}
