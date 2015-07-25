using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {



//	void OnEnable(){
//		//Cardboard.SDK.OnTrigger += Teleport;
//	}
//
//	void OnDisable(){
//		//Cardboard.SDK.OnTrigger -= Teleport;
//	}
	
	public GameObject[] teleports;

	public float teleportTime = 15f;

	private int index = 0;



	void Start(){
		teleports = GameObject.FindGameObjectsWithTag ("Teleport");
		InvokeRepeating ("Teleport", teleportTime, teleportTime);
	}

//	void Update(){
//		if (Input.GetKeyDown ("space")) {
//			Teleport();
//		}
//	}



	void Teleport(){
		index ++;
		if (index == teleports.Length) {
			index = 0;
		}
		transform.position = teleports [index].transform.position;
		transform.rotation = teleports [index].transform.rotation;
	}
}
