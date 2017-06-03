using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    //colourState tracks the current colour of the player, 0 = red, 1 = blue, 2 = green, 3 = yellow

    public static int colourState;
    public Material[] materials;
    public Renderer rend;
	private float playerspeed;




    // Use this for initialization
    void Start() {
        colourState = 0;
		playerspeed = 0.05f;


        rend = gameObject.GetComponent<Renderer>();
	}

    // Update is called once per frame
    void Update()
    {
        movePlayer(playerspeed);
		if (playerspeed < 0.45f) {
			playerspeed += 0.0001f;
		}
        if (Input.touchCount > 0)
        {
            Touch myTouch = Input.touches[0];
          
            if(myTouch.phase == TouchPhase.Began)
            {
                colourState++;
                materialColour();
            }
        }
    }

    void materialColour()
    {
        if(getColourState() == 0)
        {
            rend.material = materials[0];
        }
        if (getColourState() == 1)
        {
            rend.material = materials[1];
        }
        if (getColourState() == 2)
        {
            rend.material = materials[2];
        }
        if (getColourState() == 3)
        {
            rend.material = materials[3];
        }
    }

    private void movePlayer(float y)
    {
        transform.Translate(0, y, 0);
    }

    public int getColourState()
    {
        return colourState % 4;
    }

}
