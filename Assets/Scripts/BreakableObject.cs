using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Replace with breakable texture
        GetComponent<SpriteRenderer>().color = new Color(0, 0, 0);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("ELEPHANT");
        //Debug.Log(collision.collider.name);
        if(collision.collider.name == "Elephant")
        {
            //Debug.Log("ELEPHANT NOT");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
