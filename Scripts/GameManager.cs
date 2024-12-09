using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject tort;
    public GameObject score;
    public GameObject HP;
    public GameObject timer;
    public GameObject endGameLooseScreen;
    public GameObject endGameWinScreen;
    
    public bool loose = false;

    public void StartGameOverSequences()
    {
        loose = true;
        EndGame();
    }

    void EndGame()
    {       

        tort.SetActive(false);
        score.SetActive(false);
        HP.SetActive(false);
        timer.SetActive(false);

        DeactivateEnemies();        

        StartCoroutine(EndGameLooseScreenDelay());
    }

    void DeactivateEnemies()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            enemy.SetActive(false);
        }
    }

    IEnumerator EndGameLooseScreenDelay()
    {
        yield return new WaitForSeconds(0.3f);
        endGameLooseScreen.SetActive(true);
    }

    IEnumerator EndGameWinScreenDelay()
    {
        yield return new WaitForSeconds(0.3f);
        endGameWinScreen.SetActive(true);
    }

    public void WinStartGameOverSequences()
    {      
        tort.SetActive(false);
        score.SetActive(false);
        HP.SetActive(false);
        timer.SetActive(false);
        DeactivateEnemies();

        StartCoroutine(EndGameWinScreenDelay());       
    }
}
