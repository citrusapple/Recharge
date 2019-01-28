using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 4.0f;

    private Vector2 direction = Vector2.zero;

    public Vector2 homeLocation = Vector2.zero;

    public int hitIconsCount = 0;
    public SpawnManager SpawnManager;

    // Start is called before the first frame update
    private void Start()
    {
        transform.position = homeLocation;

    }

    // Update is called once per frame
    private void Update()
    {
        CheckInput();

        Move();
    }

    private void CheckInput()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
    }

    private void Move()
    {
        transform.localPosition += (Vector3)direction * speed * Time.deltaTime;
    }

    public void AddScore()
    {
        hitIconsCount += 1;

        if (hitIconsCount == 8)
        {
            SpawnManager.noMoreIcons = true;

            Debug.Log("noMoreIcons: " + SpawnManager.noMoreIcons);

            hitIconsCount = 0;
        }


        //add point

        //check if need to respawn things

        //display score
    }

    //// CODE BASED ON MOVING TUTORIAL --Incomplete
    //private void UpdateOrientation()
    //{
    //    if (direction == Vector2.left)
    //    {
    //    }
    //    else if (direction == Vector2.right)
    //    {
    //    }
    //    else if (direction == Vector2.left)
    //    {
    //    }
    //    else if (direction == Vector2.down)
    //    {
    //    }
    //}
}
