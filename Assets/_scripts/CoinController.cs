using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider otherGameObject) 
	{
		if (otherGameObject.tag == "Player") {
			
			
			Destroy(gameObject); //destroys coin object
		}
		
		
	}
}
