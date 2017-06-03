using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionPlayerMovement : MonoBehaviour {

    public static int colourState;
    public Material[] materials;
    public Renderer rend;
    private float playerspeed;




    // Use this for initialization
    void Start()
    {
        colourState = 0;
        playerspeed = 0.08f;


        rend = gameObject.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer(playerspeed);
        if (playerspeed < 0.45f)
        {
            playerspeed += 0.0001f;
        }

    }


    public void SetMaterialColour(int i)
    {
        if (i == 0)
        {
            rend.material = materials[0];
            colourState = 0;
        }
        if (i == 1)
        {
            rend.material = materials[1];
            colourState = 1;
        }
        if (i == 2)
        {
            rend.material = materials[2];
            colourState = 2;
        }
        if (i == 3)
        {
            rend.material = materials[3];
            colourState = 3;
        }
    }

    private void movePlayer(float y)
    {
        transform.Translate(0, y, 0);
    }

    public int getColourState()
    {
        return colourState;
    }

}
