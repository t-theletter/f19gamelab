using UnityEngine;
using System.Collections;

public class CollisionTrigger : MonoBehaviour {

	public Enemy eScript;
	int timer = 500;


	void Update(){

		if (timer > 0) {
			timer--;
		}
	}

	void OnTriggerStay2D(Collision2D other){
		if (timer == 0) {
			if (other.gameObject.tag == "Player") {
				Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D> ();
				if (eScript.rightMode = true) {
					rb.AddForce (Vector2.right * 200);
					rb.AddForce (Vector2.up * 50);
				} else if (eScript.rightMode = false) {
					rb.AddForce (Vector2.left * 200);
					rb.AddForce (Vector2.up * 50);
				}



			}
		}
	}
}
