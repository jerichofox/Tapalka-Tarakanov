using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TotalHighScore : MonoBehaviour
{
    public TMP_Text numberText; 

    void Start()
    {
        int winCount = PlayerPrefs.HasKey("winCount") ? PlayerPrefs.GetInt("winCount", 0) : 0;
        winCount++;
        PlayerPrefs.SetInt("winCount", winCount);
        PlayerPrefs.Save();

        int plCount = PlayerPrefs.HasKey("plCount") ? PlayerPrefs.GetInt("plCount", 0) : 0;
        plCount++;
        PlayerPrefs.SetInt("plCount", plCount);
        if (PlayerPrefs.GetInt("plCount") == 4)
        {
            PlayerPrefs.SetInt("plCount", 0);
            plCount = 0;
            PlayerPrefs.Save();
        }
        PlayerPrefs.Save();

        switch (plCount)
        {
            case 0:
                PlayerPrefs.SetInt("sumResult_0", PlayerPrefs.GetInt("sumResult"));
                PlayerPrefs.SetString("time_0", PlayerPrefs.GetString("time"));
                PlayerPrefs.Save();
                break;
            case 1:
                PlayerPrefs.SetInt("sumResult_1", PlayerPrefs.GetInt("sumResult"));
                PlayerPrefs.SetString("time_1", PlayerPrefs.GetString("time"));
                PlayerPrefs.Save();
                break;
            case 2:
                PlayerPrefs.SetInt("sumResult_2", PlayerPrefs.GetInt("sumResult"));
                PlayerPrefs.SetString("time_2", PlayerPrefs.GetString("time"));
                PlayerPrefs.Save();
                break;
            case 3:
                PlayerPrefs.SetInt("sumResult_3", PlayerPrefs.GetInt("sumResult"));
                PlayerPrefs.SetString("time_3", PlayerPrefs.GetString("time"));
                PlayerPrefs.Save();
                break;                      
        }

        if (PlayerPrefs.GetInt("sumResult_1") > PlayerPrefs.GetInt("bestResult"))
        {
            PlayerPrefs.SetInt("bestResult", PlayerPrefs.GetInt("sumResult_1"));
            PlayerPrefs.SetString("bestTime", PlayerPrefs.GetString("time_1"));
            PlayerPrefs.Save();
        }

        if (PlayerPrefs.GetInt("sumResult_2") > PlayerPrefs.GetInt("bestResult"))
        {
            PlayerPrefs.SetInt("bestResult", PlayerPrefs.GetInt("sumResult_2"));
            PlayerPrefs.SetString("bestTime", PlayerPrefs.GetString("time_2"));
            PlayerPrefs.Save();
        }

        if (PlayerPrefs.GetInt("sumResult_3") > PlayerPrefs.GetInt("bestResult"))
        {
            PlayerPrefs.SetInt("bestResult", PlayerPrefs.GetInt("sumResult_3"));
            PlayerPrefs.SetString("bestTime", PlayerPrefs.GetString("time_3"));
            PlayerPrefs.Save();
        }

        if (PlayerPrefs.GetInt("sumResult_0") > PlayerPrefs.GetInt("bestResult"))
        {
            PlayerPrefs.SetInt("bestResult", PlayerPrefs.GetInt("sumResult_0"));
            PlayerPrefs.SetString("bestTime", PlayerPrefs.GetString("time_0"));
            PlayerPrefs.Save();
        }

        int number = PlayerPrefs.GetInt("sumResult", 0);
        numberText.text = number.ToString();       
    }
}
