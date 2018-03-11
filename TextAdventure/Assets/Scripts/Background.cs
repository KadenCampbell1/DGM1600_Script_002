using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {
    public adventure.Location backgroundLocation;
    public Sprite[] backgroundSprite;
    public int emptyNumber;

	
	// Update is called once per frame
	void Update ()
    {
        if (backgroundLocation == adventure.Location.centerRoom)
        {
//            emptyNumber = adventure.locationSpriteNumber;
            GetComponent<SpriteRenderer>().sprite = backgroundSprite[emptyNumber];
        }
    }
}
