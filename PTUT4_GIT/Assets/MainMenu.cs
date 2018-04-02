using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void Start_the_game () {
        Application.LoadLevel("Main");
	}

    // Update is called once per frame
    public void Exit_the_game()
    {
        Application.Quit();
    }
}
