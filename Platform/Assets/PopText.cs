using UnityEngine;
using System.Collections;

public class PopText : MonoBehaviour {

	public Enemy owner;

	public void DestroySelf(){


		owner.isStartled = false;

		Destroy (gameObject);

	}
}
