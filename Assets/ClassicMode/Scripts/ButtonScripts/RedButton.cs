﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour {
    public GameObject player;
    private SelectionPlayerMovement movement;

	// Use this for initialization
	void Start () {
        movement = player.GetComponent<SelectionPlayerMovement>();
	}
	
	// Update is called once per frame
    public void OnClick()
    {
        if (player != null)
        {
            movement.SetMaterialColour(0);
        }
    }
}
