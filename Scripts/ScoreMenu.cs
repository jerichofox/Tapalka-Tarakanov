using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreMenu : MonoBehaviour
{
    public TMP_Text currentScore_0;
    public TMP_Text currentScore_1;
    public TMP_Text currentScore_2;
    public TMP_Text currentScore_3;
    public TMP_Text bestResult;
    public TMP_Text winCount;

    public GameObject stub;
    public GameObject winCnt;

    void Start()
    {
        if(PlayerPrefs.GetInt("sumResult_1") != 0)
        {
            stub.gameObject.SetActive(false);
            winCnt.gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("sumResult_0") != 0)
        {                         
            currentScore_0.text = PlayerPrefs.GetString("time_0") + "    " + PlayerPrefs.GetInt("sumResult_0").ToString();         
        }

        if (PlayerPrefs.GetInt("sumResult_1") != 0)
        {            
            currentScore_1.text = PlayerPrefs.GetString("time_1") + "    " + PlayerPrefs.GetInt("sumResult_1").ToString();
        }

        if (PlayerPrefs.GetInt("sumResult_2") != 0)
        {
            currentScore_2.text = PlayerPrefs.GetString("time_2") + "    " + PlayerPrefs.GetInt("sumResult_2").ToString();
        }

        if (PlayerPrefs.GetInt("sumResult_3") != 0)
        {
            currentScore_3.text = PlayerPrefs.GetString("time_3") + "    " + PlayerPrefs.GetInt("sumResult_3").ToString();
        }       
        
        if (PlayerPrefs.GetInt("bestResult") != 0)
        {
            bestResult.text = "best result: " + PlayerPrefs.GetString("bestTime") + "   " + PlayerPrefs.GetInt("bestResult").ToString();
        }

        winCount.text = "     Number of wins:        " + PlayerPrefs.GetInt("winCount").ToString();
    }      
}
