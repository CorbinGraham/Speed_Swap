using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {
	
	public Text score;
	public Text hiScore;
	public GameObject player;
	public GameObject pauseMenu;
	public CanvasGroup pauseMenuAlpha;

	private float playerLocation;
	private int currentScore;
	private bool flag = false;

    private int currentScene;

	private float interpolator;

	// Use this for initialization
	void Start () {
        currentScene = SceneManager.GetActiveScene().buildIndex;

		currentScore = 0;
		score.text = currentScore.ToString();
		pauseMenuAlpha = pauseMenu.GetComponent<CanvasGroup>();

        if (currentScene == 1)
        {
            hiScore.text = GameController.control.originalHighScore.ToString();
        }
        if(currentScene == 2)
        {
            hiScore.text = GameController.control.selectionHighScore.ToString();
        }



		interpolator = 0.05f;
	}
	
	// Update is called once per frame
	void Update () {
        //Most of the update section is just for scorekeeping
		if (player != null) {
			playerLocation = player.transform.position.y;
		}

		if ((((int)playerLocation) % 15) == 0 && flag == true) {
			currentScore++;
			score.text = currentScore.ToString();
			flag = false;
		}
		if ((((int)playerLocation) % 15) == 1) {
			flag = true;
		}

        //This section begins as soon as the player dies
		if (player == null) {
            //starts the coroutine to fade in the menu once you die
			pauseMenu.SetActive(true);
			StartCoroutine ("FadeMenu");

            //This saves the highscore after checking which version of the game you are in
            if (currentScene == 1)
            {
                if (GameController.control.originalHighScore < currentScore)
                {
                    GameController.control.originalHighScore = currentScore;
                    GameController.control.save();
                }
            }
            if(currentScene == 2)
            {
                if (GameController.control.selectionHighScore < currentScore)
                {
                    GameController.control.selectionHighScore = currentScore;
                    GameController.control.save();
                }
            }
        }
	}

	IEnumerator FadeMenu(){
		
		pauseMenuAlpha.alpha = Mathf.Lerp(0f, 0.99f, interpolator);
		interpolator += 0.03f;
		yield return null;
	}
		
}
