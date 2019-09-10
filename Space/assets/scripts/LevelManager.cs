using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public Text scoreText;
	public int score;


	public void adjustScore(int points){
		score = score + points;
		scoreText.text = "" + score;

	}

}
