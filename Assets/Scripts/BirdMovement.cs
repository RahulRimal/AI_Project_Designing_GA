using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public ScoreManager scoreManager;
    public GameManager gameManager;

    public GameObject scoreSound;

    Rigidbody2D rb;
    new Transform transform;
    
    public float jumpForce = 0f;
    [SerializeField]
    KeyCode keyUp;

    Quaternion upAngle = Quaternion.Euler(0, 0, 45f);
    public float upTurningRate = 100f;

    Quaternion downAngle = Quaternion.Euler(0, 0, -60f);
    public float downTurningRate = 150f; 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();

        rb.velocity = new Vector2(0, jumpForce * Time.deltaTime);
    }


    void FixedUpdate()
    {
        if(Input.GetMouseButton(0))
        {
            rb.velocity = new Vector2(0, jumpForce * Time.deltaTime);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, upAngle, upTurningRate * Time.deltaTime);
        }

        else
        {
            transform.rotation = Quaternion.RotateTowards(transform.rotation, downAngle, downTurningRate * Time.deltaTime);
        }
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        gameManager.setGameOverScreen();
        transform.rotation = Quaternion.RotateTowards(transform.rotation, downAngle, downTurningRate * Time.deltaTime);
        this.enabled = false;
        gameManager.freezeScene();
        Invoke("restartTheGame", 0.1f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "pipe")
        {
            gameManager.setGameOverScreen();
            transform.rotation = Quaternion.RotateTowards(transform.rotation, downAngle, downTurningRate * Time.deltaTime);
            this.enabled = false;
            Invoke("restartTheGame", 2f);
        }

        else
        {
            scoreManager.score++;
            Instantiate(scoreSound, transform.position, Quaternion.identity);
        }
    }

    void restartTheGame()
    {
        gameManager.resumeScene();
        gameManager.restartGame();
    }

}
