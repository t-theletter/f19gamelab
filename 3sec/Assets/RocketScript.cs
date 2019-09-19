using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour {

	float xSpeed;
	public GameObject laserProjectile;
	public GameObject TripleBlaster;
	GameObject currentPowerUp;
	bool isPoweredUp = false;
	int PowerUpTime = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (isPoweredUp = true) {
			PowerUpTime--;
			if (PowerUpTime <= 0) {
				isPoweredUp = false;
				Destroy (currentPowerUp);


			}
		}
		
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
			if (isPoweredUp == true) {
				Vector2 laserPos2 = new Vector2 (this.transform.position.x + 0.425f, this.transform.position.y + 0.6f);
				GameObject newLaser2 = Instantiate (laserProjectile); 
				newLaser2.transform.position = laserPos2;
				Vector2 laserPos3 = new Vector2 (this.transform.position.x - 0.425f, this.transform.position.y + 0.6f);
				GameObject newLaser3 = Instantiate (laserProjectile); 
				newLaser3.transform.position = laserPos3;
			}
		}

	}


	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "PowerUp") {
			Destroy (col.gameObject);
			if (isPoweredUp == false){
			GameObject newTriBlast = Instantiate(TripleBlaster);
			newTriBlast.transform.position = this.transform.position;
			newTriBlast.transform.parent = this.transform;
			currentPowerUp = newTriBlast;
			isPoweredUp = true;
			PowerUpTime = 300;
		} else if (col.gameObject.tag == "Enemy") {


		}
	}
}
}
