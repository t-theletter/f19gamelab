using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	//}

	public string enemyType;

	// Update is called once per frame
	void Update () {


		if (enemyType == "Normal") {

			float newYPos = this.transform.position.y - 0.07f;
			Vector2 newPos = new Vector2 (this.transform.position.x, newYPos);
			this.transform.position = newPos;
			if (this.transform.position.y <= -5.5f) {
				Destroy (gameObject);
			}

		} else if (enemyType == "Special") {

		}
	}



	public void getHit (){

		GameObject gManager = GameObject.Find ("GameManager");
		gManager.GetComponent<LevelManager> ().adjustScore (1);
		Destroy (gameObject);

	}
}
