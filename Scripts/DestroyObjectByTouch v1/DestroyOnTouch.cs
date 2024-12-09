using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    public AudioSource source;
    public AudioClip[] clip;

    ScoreManager scoreManager;   

    private void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        source = FindObjectOfType<AudioSource>();
    }

    public void OnMouseDown()
    {       

        if (scoreManager != null)
        {
            if (PlayerPrefs.GetInt("Sound") == 0)
            {
                source.PlayOneShot(clip[Random.Range(0, clip.Length)]);
            }               
            scoreManager.AddScore(100);            
        }      
        Destroy(gameObject);
    }
}
