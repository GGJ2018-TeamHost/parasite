using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour {

    public float xChange;
    public float yChange;
    public MovableObject linkedDoor;
    public Sprite startingSprite;
    public Sprite pushedSprite;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(xChange >= 30 || yChange >= 30)
        {
            Destroy(linkedDoor);
            Destroy(gameObject);
        }
        if (collision.collider.tag == "Player")
        {
            Debug.Log("Door Opening");
            linkedDoor.Open(xChange, yChange);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
            gameObject.GetComponent<SpriteRenderer>().sprite = pushedSprite;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
            gameObject.GetComponent<SpriteRenderer>().sprite = startingSprite;
        
    }
}
