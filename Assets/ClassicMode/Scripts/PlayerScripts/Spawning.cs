using System.Collections;
using System.Security.Cryptography;
using System.Collections.Generic;

using UnityEngine;

public class Spawning : MonoBehaviour {
    public GameObject[] walls;

	// Use this for initialization
	void Start () {
		ShuffleBag<int> bag = new ShuffleBag<int>();
        int wallcount = 15;
        for(int i = 0; i < walls.Length; i++)
        {
            walls[i].transform.localScale = new Vector3(Screen.width, 1.0f, 0.01f);
        }
			
		bag.Add (0);
		bag.Add (1);
		bag.Add (2);
		bag.Add (3);

		Instantiate (walls [0], new Vector3 (0, wallcount, 0), new Quaternion (0, 0, 0, 0));
		wallcount += 15;

		Instantiate (walls [1], new Vector3 (0, wallcount, 0), new Quaternion (0, 0, 0, 0));
		wallcount += 15;

		Instantiate (walls [2], new Vector3 (0, wallcount, 0), new Quaternion (0, 0, 0, 0));
		wallcount += 15;

		Instantiate (walls [3], new Vector3 (0, wallcount, 0), new Quaternion (0, 0, 0, 0));
		wallcount += 15;

		for (int i = 0; i < 2000; i++) {
			Instantiate (walls [bag.Next ()], new Vector3 (0, wallcount, 0), new Quaternion (0, 0, 0, 0));
			wallcount += 15;
		}
        
	}
}