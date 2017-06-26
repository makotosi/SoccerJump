using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour {

	GameObject bg;
	GameObject bg2;
	GameObject player;
	GameObject score;
	Vector3 playerPos;
	int posUp = 1;

	public GameObject steps;

	int scoreNum = 0;

	// Use this for initialization
	void Start () {
		this.player = GameObject.Find ("Player");
		this.score = GameObject.Find ("Score");
		playerPos = this.player.transform.position;
		this.scoreNum = PlayerPrefs.GetInt ("SCORE", 0);

		this.bg = GameObject.Find ("bg");
		this.bg2 = GameObject.Find ("bg2");
	}
	
	// Update is called once per frame
	void Update () {
		if (playerPos.y < this.player.transform.position.y) {
			Debug.Log(this.player.transform.position.y);
			playerPos = this.player.transform.position;
			this.scoreNum += 100;
			this.score.GetComponent<Text> ().text = "SCORE: " + this.scoreNum.ToString ();

		}
		transform.position = new Vector3 (transform.position.x, playerPos.y, transform.position.z);
		if (this.playerPos.y > this.posUp) {
			posUp += 3;
			CreateStep ();
		}
		if (this.bg.transform.position.y < this.bg2.transform.position.y) {
			if (this.player.transform.position.y > this.bg2.transform.position.y) {
				this.bg.transform.position = new Vector3 (0, this.bg2.transform.position.y + 17, 0);
			}
		} else {
			if (this.player.transform.position.y > this.bg.transform.position.y) {
				this.bg2.transform.position = new Vector3 (0, this.bg.transform.position.y + 17, 0);
			}
		}
	}

	void CreateStep() {
		Instantiate (steps, new Vector2 (Random.Range(-4.0f, 0f), (posUp + 3) + Random.Range(0, 0)), steps.transform.rotation);
		Instantiate (steps, new Vector2 (Random.Range(0f, 4.0f), (posUp + 3) + Random.Range(0, 0)), steps.transform.rotation);
		Instantiate (steps, new Vector2 (Random.Range(-4.0f, 0f), (posUp + 2) + Random.Range(0, 0)), steps.transform.rotation);
		Instantiate (steps, new Vector2 (Random.Range(0f, 4.0f), (posUp + 2) + Random.Range(0, 0)), steps.transform.rotation);
		Instantiate (steps, new Vector2 (Random.Range(-4.0f, 0f), (posUp + 1) + Random.Range(0, 0)), steps.transform.rotation);
		Instantiate (steps, new Vector2 (Random.Range(0f, 4.0f), (posUp + 1) + Random.Range(0, 0)), steps.transform.rotation);
		Instantiate (steps, new Vector2 (Random.Range(-4.0f, 0f), (posUp + 1) + Random.Range(0, 0)), steps.transform.rotation);
		Instantiate (steps, new Vector2 (Random.Range(0f, 4.0f), (posUp + 3) + Random.Range(0, 0)), steps.transform.rotation);
	}
}
