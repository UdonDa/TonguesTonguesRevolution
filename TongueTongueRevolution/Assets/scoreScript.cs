﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class scoreScript : MonoBehaviour {

	public GameObject ResultController;

	public Text scoretext;

	private string tempScore;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		tempScore = (GameManager.score).ToString();
		scoretext.text = tempScore;
	}
}
