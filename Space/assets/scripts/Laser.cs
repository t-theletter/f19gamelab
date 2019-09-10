using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	//}

	// Update is called once per frame
	void Update () {

		float newYPos = this.transform.position.y + 0.15f;
		Vector2 newPos = new Vector2 (this.transform.position.x, newYPos);
		this.transform.position = newPos;
		if (this.transform.position.y >= 6) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			col.gameObject.GetComponent<EnemyScript> ().getHit ();
			Destroy (gameObject);
		} else {

		}
	}
}
