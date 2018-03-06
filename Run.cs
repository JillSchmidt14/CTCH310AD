//*Run
//Created By: Jill Schmidt
//Feb.14th/18
//CTCH310


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour {

	public float speed;
	public GameObject  player;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		float dist = Vector3.Distance (player.transform.position, transform.position);

		Vector3 localPosition = player.transform.position - transform.position;
		localPosition = localPosition.normalized;

		if (dist < 5) {
			transform.Translate (localPosition.x * Time.deltaTime * speed * -1,
				0.0f,
				localPosition.z * Time.deltaTime * speed * -1);
		}


	}
}
