using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;



    void Start()
    {
        gameOverScreen.SetActive(false);
        Time.timeScale = 1;
    }


    public void setGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

    public void freezeScene()
    {
        Time.timeScale = 0.06f;
    }

    public void resumeScene()
    {
        Time.timeScale = 1f;
    }


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
