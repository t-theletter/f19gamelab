using UnityEngine;
using System.Collections;

public class EnemySpaw : MonoBehaviour {

	public GameObject ufo1;
	int timeUntilNextSpawn = 0;


	// Use this for initialization
	void Start () {
		Vector2 ufoPos = new Vector2 (0f, 5.75f);
		spawnenemy (ufo1, ufoPos);
	}
	
	// Update is called once per frame
	void Update () {
		if (timeUntilNextSpawn <= 0) {
			float randomPos = Random.Range (-2.4f, 2.4f);
			Vector2 ufoPos = new Vector2 (randomPos, 5.75f);
			spawnenemy (ufo1, ufoPos);

			float randomTime = Random.Range (15f, 20f);
			timeUntilNextSpawn = (int) randomTime;

		}
		timeUntilNextSpawn--;

	}


	void spawnenemy(GameObject enemyToSpawn, Vector2 spawnLocation){
		GameObject newEnemy = Instantiate (enemyToSpawn);
		newEnemy.transform.position = spawnLocation;

	}
}
