﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {

    int movecntY = 0;
    int movecntX = 0;

    [Header("HP")]
    public static int hp = 5;

    // Use this for initialization
    void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}

    void Move()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            if (movecntX < 3)
            {
                transform.Translate(-1, 0, 0);
                movecntX++;
                movecntY--;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (movecntY < 3)
            {
                transform.Translate(1, 0, 0);
                movecntY++;
                movecntX--;
            }
        }
    }
}
