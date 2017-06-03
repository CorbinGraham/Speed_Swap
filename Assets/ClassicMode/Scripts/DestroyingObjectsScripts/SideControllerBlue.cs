﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideControllerBlue : MonoBehaviour
{
    public GameObject player;
    public PlayerMovement movement;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        movement = player.GetComponent<PlayerMovement>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (movement.getColourState() != 1)
        {
            Destroy(player);
        }
    }
}
