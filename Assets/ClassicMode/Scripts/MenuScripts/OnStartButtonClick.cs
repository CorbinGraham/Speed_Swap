﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnStartButtonClick : MonoBehaviour
{

    public void LoadSceneOnClick(int scene)
    {
                SceneManager.LoadScene(scene);
    }
}

