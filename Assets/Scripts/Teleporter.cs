using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

	public GameObject[] teleports;

	private int index = 0;

	void Start(){
		teleports = GameObject.FindGameObjectsWithTag ("Teleport");
	}

	void Update(){
		if (Input.GetKeyDown ("space")) {
			Teleport();
		}
	}

	void Teleport(){
		index ++;
		if (index == teleports.Length) {
			index = 0;
		}
		transform.position = teleports [index].transform.position;
	}
}
