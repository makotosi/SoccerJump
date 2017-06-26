using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightController : MonoBehaviour {

	GameObject player;
	float vectorForce = 1.0f;
	float force = 0;

	// Use this for initialization
	void Start () {
		this.player = GameObject.Find ("Player");
	}

	public void Clicked(){
		force = PlayerPrefs.GetFloat ("X", 0) + vectorForce;
		float y = this.player.GetComponent<Rigidbody2D> ().velocity.y;
		PlayerPrefs.SetFloat ("X", force);
		this.player.GetComponent<Rigidbody2D> ().velocity = new Vector3 (force, y, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
