using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public GameObject startSound;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startGame();
        }
    }

    public void startGame()
    {
        Instantiate(startSound, transform.position, Quaternion.identity);
        SceneManager.LoadScene(1);

    }
}
