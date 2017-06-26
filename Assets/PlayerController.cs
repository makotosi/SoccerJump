using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	Rigidbody2D rigid2D;
	float jumpForce = 7.0f;

	GameObject rightAnchor;

	// Use this for initialization
	void Start () {
		this.rigid2D = GetComponent<Rigidbody2D> ();
		this.rightAnchor = GameObject.Find ("RightAnchor");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -10) {
			SceneManager.LoadScene ("OverScene");
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		float x = PlayerPrefs.GetFloat ("X", 0);
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector3 (x, jumpForce, 0);
	}
}
