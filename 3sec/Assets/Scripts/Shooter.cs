using UnityEngine;
using System.Collections;
using UnityEngine;

public class Shooter : MonoBehaviour {

   //List<string> letters = new List<string>();
   //string[] mywords = new string[] { "BIG BROTHER IS WATCHING YOU" };
   //string myword;
  // public Text text;

    public GameObject BulletProjectile;
	public GameObject Protector;
	public GameObject Boss;
	public GameObject Bullet;
	public Transform Target;
	public float RotationSpeed;
	public GameObject spawnLoc;
	private Quaternion _lookRotation;
	private Vector3 _direction;

	float angle = 0;
	float speed=(2*Mathf.PI)/5;
	float radius = 4;


	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
		angle += speed * Time.deltaTime;
		float x = Mathf.Cos (angle) * radius;
		float y = Mathf.Sin (angle) * radius;
		Vector2 newPos = new Vector2 (x, y);
		this.transform.position = newPos;

		Vector3 center = new Vector3(0f,0f,0f);
		Vector3 diff = center - transform.position;
		diff.Normalize();

		float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);


		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject newBullet = Instantiate (BulletProjectile); 
			newBullet.transform.position = spawnLoc.transform.position;



		}
	}
}
