using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour {

	public Text version;

	private void Start () {

		version.text = "Version : " + Application.version + "    "; // Displays the varion of the Application
		Debug.Log("Application Version : " + Application.version); 
	}
	
	// To PlayGame
	public void PlayGame()
	{
		Debug.Log("Play");
		SceneManager.LoadScene(1); // Loads the game scene
	}
	
}
