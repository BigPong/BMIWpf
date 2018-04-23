using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSystem : MonoBehaviour {

	public GameObject b;
	int cooldown=0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (cooldown >= 35) {
			
			Instantiate(b);
			cooldown = 0;
		} else {
			cooldown++;
		}
	}
}
