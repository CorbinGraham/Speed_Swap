using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScrips : MonoBehaviour {
    public GameObject player;
    public GameObject menu;
    public GameObject resume;

	
	// Update is called once per frame
	void Start () {
        player = GameObject.Find("Player");
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(player);
        menu.SetActive(true);
        resume.SetActive(false);
        

    }
}
