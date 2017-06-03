using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButtonScript : MonoBehaviour {
    public GameObject menu;
    public GameObject player;
    
    public void onPressed()
    {
        menu.SetActive(true);
        if (player != null)
        {
            player.SetActive(false);
        }
    }
}
