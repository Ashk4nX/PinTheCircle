using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager Instance;

	[SerializeField]
	private GameObject Needle;

	private float ValueY;

	void Awake ()
	{

		if (Instance == null) {

			Instance = this;

		}

	}

	void Start ()
	{

		InstantiateNeedle ();

	}

	public void InstantiateNeedle ()
	{

		ValueY = Random.Range(-4f, -0.5f);

		Vector3 temp = new Vector3 (0, ValueY , 0);

		Instantiate (Needle, temp, Quaternion.identity);


	}

}
