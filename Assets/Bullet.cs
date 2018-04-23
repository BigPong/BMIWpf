using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	Rigidbody rb;
	Vector3 pos;
	public float speed=5;
	void Start () {
		rb = this.GetComponent<Rigidbody> ();
		float y = Random.Range (5.5f, -3.5f);
		float x = 15;
		float z = -1;
		pos = new Vector3(x,y,z);
		transform.position = pos;
        Destroy(this.gameObject,15f);
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3 (-speed,0 , 0);
		rb.MovePosition (transform.position + movement);
	}

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
