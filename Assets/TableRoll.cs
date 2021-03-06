﻿using UnityEngine;
using System.Collections;

public class TableRoll : MonoBehaviour {

	private float turnSpeed = 0.25f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float rX = transform.eulerAngles.x;
		float rY = transform.eulerAngles.y;
		float rZ = transform.eulerAngles.z;
        //to limit the rotation
		if (rX > 10 && rX < 350) {
			if (rX < 180) {
				transform.Rotate (Vector3.right, 10 - rX);
			} else {
				transform.Rotate (Vector3.right, 350 - rX);
			}
		}
		if (rZ > 10 && rZ < 350) {
			if (rZ < 180) {
				transform.Rotate (Vector3.forward, 10 - rZ);
			} else {
				transform.Rotate (Vector3.forward, 350 - rZ);
			}
		}
        //to tilt the table upward
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.Rotate (Vector3.right, turnSpeed);
		}
        //to tilt the table downward
		if (Input.GetKey (KeyCode.DownArrow)) {
			transform.Rotate (Vector3.right, -turnSpeed);
		}
        //to tilt the table to the right
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Rotate (Vector3.forward, -turnSpeed);
		}
        //to tilt the table to the left
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Rotate (Vector3.forward, turnSpeed);
		}
	}
}
