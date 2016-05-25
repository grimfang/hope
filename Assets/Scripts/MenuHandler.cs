using UnityEngine;
using System.Collections;

public class MenuHandler : MonoBehaviour {

	public void StartGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("baseScene");
	}

	public void OpenHelp()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Help");
	}

	public void OpenMain()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene ("Menu");
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
