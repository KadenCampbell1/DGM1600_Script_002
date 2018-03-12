using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour {
    public adventure.Location backgroundLocation;
    public Sprite[] backgroundSprite;
    public int emptyNumber = 0;
    public Image backgroundImage; 

    private void Start()
    {
        backgroundImage = GetComponent<Image>(); 
    }

    // Update is called once per frame
    void Update ()
    {
        if (backgroundLocation == adventure.Location.centerRoom)
        {
//            emptyNumber = adventure.locationSpriteNumber;
            backgroundImage.sprite = backgroundSprite[emptyNumber];
        }
    }
}
