using UnityEngine;
using System.Collections;

public class MineController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider otherGameObject) 
	{
		if (otherGameObject.tag == "Player") {

			Destroy(gameObject); //destroys mine object
		}
	}
}
