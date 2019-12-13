using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadGame : MonoBehaviour
{
   public void StartOver()
    {
        GameOver.IsGameOver = false;
        Time.timeScale = 1;
        SceneManager.LoadScene("GameScene");
    }
}
