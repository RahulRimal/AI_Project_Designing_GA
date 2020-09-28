using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    public GameObject[] pipes;

    public float spawnRate = 2.5f;
    public float timeToSpawn = 0f;

    
    void Start()
    {
        timeToSpawn = 0;
    }


    void Update()
    {
        int pipeChoice = Random.Range(0, pipes.Length);

        if(timeToSpawn < 0)
        {
            Instantiate(pipes[pipeChoice], pipes[pipeChoice].transform.position, Quaternion.identity);
            timeToSpawn = spawnRate;
        }

        else
        {
            timeToSpawn -= Time.deltaTime;
        }
        
    }
}
