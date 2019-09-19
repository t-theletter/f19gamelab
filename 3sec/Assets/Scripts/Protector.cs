using UnityEngine;
using System.Collections;

public class Protector : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	//}
	// Update is called once per frame

	void Update () {
		transform.Rotate (0, 0,-50*Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D col){
		if (col.gameObject.tag == "Bullet") {
			Destroy (col.gameObject);
		}
	}
}
