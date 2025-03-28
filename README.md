# flappybird_project
Game development lecture lab project

" drive link: https://drive.google.com/file/d/1lKxteLOWriYut2E7n5J5mcIbOyJ3aP05/view?usp=sharing " 

BirdScript.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource flap;
    public AudioSource col;

    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector3(3, 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive==true) 
        {
            myRigidBody.linearVelocity = Vector2.up * flapStrength; //myRigidBody.velocity = new Vector2(0, 1)
            flap.Play();
        }

        if(transform.position.y > 16 || transform.position.y < -16)
        {
            logic.gameOver();
            birdIsAlive = false;
            gameObject.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        col.Play();
        logic.gameOver();
        birdIsAlive = false;
    }
}
