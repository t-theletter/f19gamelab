using UnityEngine;
using System.Collections;

public class StarSpawner : MonoBehaviour {

	public GameObject ufo1;
	int timeUntilNextSpawn = 0;


	// Use this for initialization
	void Start () {
		Vector2 ufoPos = new Vector2 (0f, 5.75f);
		spawnStar (ufo1, ufoPos);
	}

	// Update is called once per frame
	void Update () {
		if (timeUntilNextSpawn <= 0) {
			float randomPos = Random.Range (-3.4f, 3.4f);
			Vector2 starPos = new Vector2 (randomPos, 5.75f);
			spawnStar (ufo1, starPos);

			float randomTime = Random.Range (0f, 5f);
			timeUntilNextSpawn = (int) randomTime;

		}
		timeUntilNextSpawn--;

	}


	void spawnStar(GameObject starToSpawn, Vector2 spawnLocation){
		GameObject newStar = Instantiate (starToSpawn);
		newStar.transform.position = spawnLocation;

	}
}
