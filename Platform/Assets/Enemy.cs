using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {


	public enum mode{
		patrol,
		startled,
		angry

	}

	public mode enemyState;
	public GameObject leftPoint;
	public GameObject rightPoint;
	float speed = 0.1f;
	float patrolSpeed = 0.1f;
	float angrySpeed = 0.2f;
	public bool rightMode = true;
	bool visionModeRight = true;
	public bool isStartled;
	public bool moving = true;
	public GameObject target;
	public Vision Vision;
	public GameObject popUpText;






	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (moving == true) {




			Vector2 newPos = new Vector2 (0f, 0f);

			if (rightMode == true) {
				newPos = new Vector2 (this.transform.position.x + speed, this.transform.position.y);
			} else if (rightMode == false) {
				newPos = new Vector2 (this.transform.position.x - speed, this.transform.position.y);
			}
					
			this.transform.position = newPos;

			if (enemyState == mode.patrol) {
				
				if (transform.position.x >= rightPoint.transform.position.x) {
					rightMode = false;
				}

				if (transform.position.x <= leftPoint.transform.position.x) {
					rightMode = true;
				}

			} else if (enemyState == mode.angry) {
				if (transform.position.x >= target.transform.position.x) {
					rightMode = false;
				}

				if (transform.position.x <= target.transform.position.x) {
					rightMode = true;
				}
			}
				


				if (rightMode != visionModeRight) {
				Vision.SetVisionArea(rightMode);
				visionModeRight = rightMode;
			}
		}else{
			if (enemyState == mode.startled) {
				if (isStartled == false) {
					speed = angrySpeed;
					enemyState = mode.angry;
					moving = true;

					}
				}
			}
		}

	public void UpdateVision (bool canSee, GameObject whatIsSeen){

		if (canSee == true) {

			GameObject newPop = Instantiate (popUpText);
			newPop.transform.position = this.transform.position;
			newPop.GetComponent <PopText>().owner = this;
			enemyState = mode.startled;
			moving = false;
			isStartled = true;
			target = whatIsSeen;
		}

		if (canSee == false) {
			moving = true;
			speed = patrolSpeed;
			enemyState = mode.patrol;
		}
	}

}
