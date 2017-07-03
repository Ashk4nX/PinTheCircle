using UnityEngine;
using System.Collections;

public class CircleRotation : MonoBehaviour {

	[SerializeField]
	private float RotationSpeed = 30f;

	private float angel;
	private bool canRotate;

	void Awake ()
	{
		canRotate = true;
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (canRotate == true) {

			RotateTheCircle ();
			
		}
	
	}

	void RotateTheCircle ()
	{

		angel = this.transform.rotation.eulerAngles.z;
		angel += RotationSpeed * Time.deltaTime;
		this.transform.rotation = Quaternion.Euler (0, 0, angel);

	}
}
