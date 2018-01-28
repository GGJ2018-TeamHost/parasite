using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatVisionController : MonoBehaviour {

	private GameObject[] visionObjects;
	void Start () {
		visionObjects = GameObject.FindGameObjectsWithTag("catVision");
		setCatObjectVisibility (false);
	}

	public void setCatObjectVisibility(bool state)
	{
		// Show invisible game objects using cat vision.
		foreach (GameObject o in visionObjects)
		{
			// o.SetActive (state);
			o.GetComponent<SpriteRenderer>().enabled = state;
		}
	}
}
