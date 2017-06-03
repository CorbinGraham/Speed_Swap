using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionSideControllerBlue : MonoBehaviour {
    public GameObject player;
    public SelectionPlayerMovement movement;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        movement = player.GetComponent<SelectionPlayerMovement>();

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (movement.getColourState() != 1)
        {
            Destroy(player);
        }
    }
}
