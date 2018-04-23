using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	Rigidbody rb;
	public float speed=3;
	bool jump=true;
	public float a = 0;
    int hp;
	public float g = 4;
	Vector3 movement;
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		a += g;
		rb.velocity -= new Vector3 (0, a, 0);
		Move ();
		Jump ();
	}

	void Move(){
		float h;
		h = Input.GetAxis ("Horizontal");
		movement.Set (h, 0, 0);
		movement = movement.normalized * speed * Time.deltaTime;
		rb.MovePosition (transform.position + movement);
	}

	void Jump(){
		if (Input.GetButtonDown ("Jump") /*&& jump*/) {
			print (1);
			a = 0;
			Vector3 jumpf = new Vector3 (0,  7.5f,0);
			rb.velocity = (jumpf);
			jump = false;
		} else if (Input.GetButtonUp ("Jump") != true) {
			jump = true;
		}
	}
}
