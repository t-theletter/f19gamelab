using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour {

	float xSpeed;
	public GameObject laserProjectile;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			xSpeed = -0.1f;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			xSpeed = 0.1f;
		} else {
			xSpeed = 0f;
		}

		float newXPos = this.transform.position.x + xSpeed;

		if((newXPos<3)&&(newXPos>-3)){
		Vector2 newPos = new Vector2 (newXPos, this.transform.position.y);
		this.transform.position = newPos;

		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			Vector2 laserPos = new Vector2 (this.transform.position.x, this.transform.position.y + 0.8f);
			GameObject newLaser = Instantiate (laserProjectile); 
			newLaser.transform.position = laserPos;
		}
	}
}
