using UnityEngine;
using System.Collections;

/*public enum RespawnPosition{
	lane1,
	lane2,
	lane3,
	lane4,
	lane5
}*/

public class CarRespawn : MonoBehaviour {
	
	public GameObject lane1;
	public GameObject lane2;
	public GameObject lane3;
	public GameObject lane4;
	public GameObject lane5;
	
	//public GameObject[5] lane;
	
	// Use this for initialization
	void Start () {
		/*for(lane[i];i>;i++){
			
		}*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Car"){
			int randomPos= Random.Range (0,6);
			other.transform.position= new Vector3(0,0,0);
		}
    }
}


