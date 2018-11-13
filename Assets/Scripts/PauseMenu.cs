using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	public GameObject pauseMenuUI;


	void Start (){
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
		{
			Pause ();
		}
	}

	public void Resume () 
	{
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
	}

	void Pause () 
	{
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
	}

	public void LoadMenu () 
	{
		SceneManager.LoadScene ("Menu", LoadSceneMode.Single);
		//Debug.Log ("Loading menu...");
	}

	public void QuitGame () 
	{
		//Debug.Log ("Quitting game...");
		Application.Quit ();
	}

	public void RestartGame() 
	{
		SceneManager.LoadScene ("Level", LoadSceneMode.Single);
		//Debug.Log ("Loading Restart...");
	}
}