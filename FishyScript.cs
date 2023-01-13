using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishyScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public LogicManagerScript logic;
    public bool birdIsALive = true;
    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && birdIsALive) 
        {
            myRigidbody.velocity = Vector2.up * flapStrenght;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsALive = false;
    }
}
