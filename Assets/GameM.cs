using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameM : MonoBehaviour
{
    public GameObject gameOverCanvas;
    void Start()
    {
        Time.timeScale = 1;
    }


    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
}
