using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour {
    // Use this for initialization
    float startX;
    float startY;
    float xRate;
    float yRate;

    void Start () {
        startX = transform.position.x;
        startY = transform.position.y;
        //Debug.Log(startX + " " + startY);
    }
	
    //Default is for a vertical object moving up
    public void Open(float xRate_, float yRate_)
    {
        xRate = xRate_;
        yRate = yRate_;
        gameObject.transform.Translate(xRate, yRate, 0);
    }

	// Update is called once per frame
	void Update () {
            gameObject.transform.Translate(-xRate/10, 0, 0);
            gameObject.transform.Translate(0, (-yRate/10), 0);
    }
}
