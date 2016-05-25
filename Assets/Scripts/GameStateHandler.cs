using UnityEngine;
using System.Collections;

public class GameStateHandler : MonoBehaviour {

	public static GameStateHandler instance = null;
	public GameObject menuManager;

	private int gameState;

	void Awake() {
		if (instance == null) {
			instance = this;
		} else if (instance != this) {
			Destroy (gameObject);
		}

		DontDestroyOnLoad (gameObject);

		InitMenu ();
	}

	// Start Menu
	void InitMenu()
	{

	}

	// Start Game
	void InitGame(int gm)
	{

	}
}
