using UnityEngine;
using System.Collections;

public class Eye : MonoBehaviour {
	public Timer Waffel;
	// Use this for initialization
	//void Start () {
	//}
	// Update is called once per frame

	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == "Bullet") {
			Waffel.isWinning = true;
			Destroy (col.gameObject);
			Destroy (gameObject);
		}
	}
	}


			
		
