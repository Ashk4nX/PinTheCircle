using UnityEngine;
using System.Collections;

public class NeedleMovement : MonoBehaviour {


	//[SerializeField]
	//private GameObject NeedleBody;

	private float SpeedY = 5f;
	private bool CanFireNeedle;
	private bool NeedleTouchedTheCircle;
	private Rigidbody2D MyBody;


	void Awake ()
	{
		Initialize ();
	}

	void Start ()
	{

	}

	void Initialize ()
	{

		MyBody = gameObject.GetComponent<Rigidbody2D>();

	}

	public void FireTheNeedle ()
	{

		MyBody.isKinematic = false;
		CanFireNeedle = true;

	}
	
	// Update is called once per frame
	void Update ()
	{

		if (CanFireNeedle == true) {

			MyBody.velocity = new Vector2 (0, SpeedY);

		}
	
	}

	void OnTriggerEnter2D (Collider2D target)
	{

		if (NeedleTouchedTheCircle == true) {

			return;

		}

		if (target.tag == "Circle") {

			Debug.Log ("Needle Touched the Circle");
			CanFireNeedle = false;
			MyBody.isKinematic = true;
			MyBody.simulated = false;
			NeedleTouchedTheCircle = true;
			gameObject.transform.SetParent (target.transform);

			if (GameManager.Instance != null) {

				GameManager.Instance.InstantiateNeedle();

			}
		}

	}

}
