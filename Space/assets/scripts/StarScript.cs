using UnityEngine;
using System.Collections;

public class StarScript : MonoBehaviour {

	float starSpeed = 0.1f;

	// Use this for initialization
	void Start () {
		starSpeed = Random.Range (0.01f, 0.03f);
	}
	
	// Update is called once per frame
	void Update () {
		float newYPos = this.transform.position.y - starSpeed;
		Vector2 newPos = new Vector2 (this.transform.position.x, newYPos);
		this.transform.position = newPos;
		if (this.transform.position.y <= -6) {
			Destroy (gameObject);
		}
	}
}