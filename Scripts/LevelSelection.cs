using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelSelection : MonoBehaviour
{    

    public Button[] lvlButtons;

    private void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 4);        

        for (int i = 0; i < lvlButtons.Length; i++)
        {                   

            if (i + 1 > levelAt)
            {              
                lvlButtons[i].interactable = false;                
            }               
        }
    }
}
