using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnResumePressed : MonoBehaviour {
    public GameObject player;
    public GameObject menu;

    public void onPressed()
    {

        if (player != null)
        {
            player.SetActive(true);
            menu.SetActive(false);
        }

    }
}
