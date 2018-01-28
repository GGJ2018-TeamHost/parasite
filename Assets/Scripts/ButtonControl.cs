﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour {

    public float xChange;
    public float yChange;
    public MovableObject linkedDoor;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
            linkedDoor.Open(xChange, yChange);
    }
    void Update () {
		
	}
}
