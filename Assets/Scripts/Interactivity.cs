﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactivity : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void setInteractive()
	{
		GameObject.Find("GameManager").GetComponent<GameManager>().isInteractive = !GameObject.Find("GameManager").GetComponent<GameManager>().isInteractive;
		//GameObject.Find("GameManager").GetComponent<GameManager>().isInteractive = true;
	}
}
