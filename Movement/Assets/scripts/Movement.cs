using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour 
{

	public float speed; 
	public float timer;
	public GameObject circle; 
	float posx; 
	float posy;
	public float freq;
	public float amp;

	// Use this for initialization
	void Start () 
	{
		Debug.Log(transform.position);
		
		//transform.position = new Vector2(3, 1);
		transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
		speed = 5;
		timer = 0;
		circle.transform.position = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		//transform.Translate(new Vector2(1, 0)*Time.deltaTime*speed);
		
		if (timer >= 1)
		{
		
		transform.position = new Vector2(Random.Range(-20, 20), Random.Range(-20, 20));
		timer = 0;
		}
		timer+= Time.deltaTime;
		//timer = timer + Time.deltaTime;
		
		posx = Mathf.Sin(Time.time*freq)*Mathf.Sin(Time.time)*amp;
		posy = Mathf.Cos(Time.time*freq)*Mathf.Sin(Time.time)*amp;
		Debug.Log(posx);
		
		circle.transform.position = new Vector2(posx + transform.position.x, posy + transform.position.y);
		
		//Time.time; 
		//amount of second since start of game
		//Time.deltaTime
		//amount of time that passes between frames
	}
}








