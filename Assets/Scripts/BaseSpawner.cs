using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpawner : MonoBehaviour
{
    public GameObject ground;

    public float timeToSpawn = 2f;
    public float shouldSpawn = 0f;

    void Start()
    {
        shouldSpawn = timeToSpawn;
    }

    void Update()
    {
        if(shouldSpawn < 0)
        {
            Instantiate(ground, ground.transform.position, Quaternion.identity);
            shouldSpawn = timeToSpawn;
        }
        else
        {
            shouldSpawn -= Time.deltaTime;   
        }
    }


}
