using UnityEngine;
using System.Collections;

public class Vision : MonoBehaviour {

	public Enemy eScript;



	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			eScript.UpdateVision (true, other.gameObject);
		}
	}
		
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			eScript.UpdateVision (false, other.gameObject);
		}
	}

	public void SetVisionArea (bool isRight){
		if (isRight == true) {
			Vector2 newPos = new Vector2 (1.54f, this.transform.localPosition.y);
			this.gameObject.transform.localPosition = newPos;
		} else if (isRight == false) {
			Vector2 newPos = new Vector2 (-1.54f, this.transform.localPosition.y);
			this.gameObject.transform.localPosition = newPos;
		}
	}
}
