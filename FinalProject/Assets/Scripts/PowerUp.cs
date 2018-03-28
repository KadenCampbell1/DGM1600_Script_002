using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode] //allows script to run in the editor
public class PowerUp : MonoBehaviour {


    public enum Power { Health, Speed};
    public Power powerUpType;
    private SpriteRenderer rend;
    public Sprite[] images;


	// Use this for initialization
	private void Start ()
    {
        rend = GetComponent<SpriteRenderer>();
        
	}
	
	// Update is called once per frame
	private void Update ()
    {
        switch (powerUpType)
        {
            case Power.Health:
                //do some stuff
                rend.sprite = images[0];
                break;
            case Power.Speed:
                //do some other stuff
                rend.sprite = images[1];
                break;
        }
    }
}
