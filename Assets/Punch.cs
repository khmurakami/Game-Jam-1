﻿using UnityEngine;
using System.Collections;

public class Punch : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P)){
            this.GetComponent<Animator>().SetTrigger("punch");
        }
	}
}
