using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour {

	public Text version;
	// Use this for initialization
	private void Start () {

		version.text = "Version : " + Application.version + "    ";
		Debug.Log("Application Version : " + Application.version);
	}
	
	// To PlayGame
	public void PlayGame()
	{
		Debug.Log("Play");
		SceneManager.LoadScene(1);
	}
	
}
