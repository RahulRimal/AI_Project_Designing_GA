using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    
    public float movementSpeed = 0f;


    void Update()
    {
        transform.Translate(Vector2.left * movementSpeed * Time.deltaTime);
        Invoke("destroy", 6f);
    }


    void destroy()
    {
        Destroy(gameObject);
    }


}
