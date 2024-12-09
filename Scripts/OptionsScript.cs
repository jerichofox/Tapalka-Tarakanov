using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour
{
    public GameObject off;
    public GameObject on;
      

    void Update()
    {
        if (PlayerPrefs.GetInt("Sound") == 0)
        {
            off.gameObject.SetActive(false);
            on.gameObject.SetActive(true);
        }
        else if (PlayerPrefs.GetInt("Sound") == 1)
        {
            off.gameObject.SetActive(true);
            on.gameObject.SetActive(false);
        }        
    }

    public void Sound()
    {
        if (PlayerPrefs.GetInt("Sound") == 0)
        {
            PlayerPrefs.SetInt("Sound", 1);
            PlayerPrefs.Save();
            off.gameObject.SetActive(true);
            on.gameObject.SetActive(false);
        }
        else if (PlayerPrefs.GetInt("Sound") == 1)
        {
            PlayerPrefs.SetInt("Sound", 0);
            PlayerPrefs.Save();
            off.gameObject.SetActive(false);
            on.gameObject.SetActive(true);
        }
    }
}
