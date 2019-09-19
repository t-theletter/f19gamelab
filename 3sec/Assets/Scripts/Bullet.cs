using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	float speed = 0.1f;




	// Use this for initialization
	//void Start () {
	//}
	// Update is called once per frame
	void Update () {
		Vector3 center = new Vector3(0f,0f,0f);
		Vector3 diff = center - transform.position;
		diff.Normalize();

		float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);
		float x = this.transform.position.x;
		float newX = 0f;
		float y = this.transform.position.y;
		float newY = 0f;

		if (x > 0) {
			newX = x - speed;
		}else if (x < 0) {
			newX = x + speed;
		}

		if (y > 0) {
			newY = y - speed;
		}else if (y < 0) {
			newY = y + speed;
		}
			

		Vector2 newPos = new Vector2 (newX, newY);
		this.transform.position = newPos;

        //if (newPos(newX = 0))
        {
           // Destroy(gameObject);
           //empty game object in the middle w/ collider
           //if col., destroy gameObject
        }

	}


}