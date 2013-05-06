using UnityEngine;
using System.Collections;

public class PathMovement : MonoBehaviour {
	
	private float pathMovement;
	public float posEnd;
	public float posStart=0;
	
	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0,0,-5* Time.deltaTime);
		if(transform.position.z < posEnd){
			transform.position= new Vector3(0,-10.47f,posStart);	
		}
	}
}
