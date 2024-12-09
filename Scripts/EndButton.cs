using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndButton : MonoBehaviour
{
    public void EndButtonLoad()
    {
        StartCoroutine(Wait());        
    }

    IEnumerator Wait()
    {
        if (PlayerPrefs.GetInt("Sound") == 0)
        {
            if (SystemInfo.deviceType == DeviceType.Handheld)
            {
                Handheld.Vibrate();
            }
        }          

        yield return new WaitForSeconds(2);        
        SceneManager.LoadScene("MainMenu");        
    }
}
