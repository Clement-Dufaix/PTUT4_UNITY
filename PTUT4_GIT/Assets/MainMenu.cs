using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void Start_the_game () {
        // Application.LoadLevel("Main");
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    public void Exit_the_game()
    {
        Application.Quit();
    }
}
