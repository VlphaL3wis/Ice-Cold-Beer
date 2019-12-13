using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject gameOverText;
    private AudioSource audioSource;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        GameOver.IsGameOver = false;
    }

    
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.CompareTag("Player"))
        {
            gameOverText.SetActive(true);
            audioSource.Play();
            Debug.Log("Has touched the obstacle");
            GameOver.IsGameOver = true;
            Time.timeScale = 0;
        }
        
    }
}
