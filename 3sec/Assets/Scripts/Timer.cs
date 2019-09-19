using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text time;
	public bool isWinning = false;
	int seconds = 8;
	int interval = 80;

	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	void Update () {

		if (seconds > 0) {

			interval--;
			if (interval <= 0) {
				interval = 80;
				seconds--;
                time.text = "" + seconds;
                if (seconds == 0)
                {
					
					if (isWinning == true) {
						time.text = "WIN";
					} else {
						time.text = "LOSE";
					}
				}
			}
		}
	}	
}
