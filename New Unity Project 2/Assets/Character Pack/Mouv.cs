using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Mouv : NetworkBehaviour {
	private Transform myTransform;
	public float speed = 3.0f;
	// Use this for initialization
	void Start () {
		myTransform = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (isLocalPlayer) {
			if (Input.GetKey (KeyCode.UpArrow))
				{
				myTransform.Translate (Vector3.forward * speed * Time.deltaTime,Space.Self);
				}
			if (Input.GetKey (KeyCode.DownArrow)) {
				myTransform.Translate (-1 * Vector3.forward * speed * Time.deltaTime, Space.Self);
			}
		}
		
	}
}
