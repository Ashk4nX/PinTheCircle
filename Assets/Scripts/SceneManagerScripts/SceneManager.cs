using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneManager : MonoBehaviour {

	void Awake () {


	}

	public void LoadPlay () {

		EditorSceneManager.LoadScene("Gameplay");

	}

	public void LoadLeaderboard () {

		EditorSceneManager.LoadScene("Leaderboard");

	}

	public void LoadRate () {

		EditorSceneManager.LoadScene("Rate");

	}

	public void LoadShare () {

		EditorSceneManager.LoadScene("Share");

	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
