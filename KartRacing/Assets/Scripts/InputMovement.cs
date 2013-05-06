using UnityEngine;
using System.Collections;

public class InputMovement : MonoBehaviour {
	
	private float movementSpeed= 4;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float horizontalSpeed = Input.GetAxis("Horizontal") * Time.deltaTime * -movementSpeed;
		float verticalSpeed = Input.GetAxis("Vertical") * Time.deltaTime * -movementSpeed;
		transform.Translate(horizontalSpeed, 0, verticalSpeed);
	}
	
	
}
