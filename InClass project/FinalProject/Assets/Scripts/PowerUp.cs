using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[ExecuteInEditMode] //allows script to run in the editor
public class PowerUp : MonoBehaviour {


    public enum Power { Health, Speed, Damage};
    public Power powerUpType;
    private SpriteRenderer rend;
    public Sprite[] images;
    public bool random;

	// Use this for initialization
	private void Start ()
    {
        rend = GetComponent<SpriteRenderer>();
        if (random)
        {
            powerUpType = (Power)(Random.Range(0, 2));
        }
        
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
            case Power.Damage:
                rend.sprite = images[2];
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        switch (powerUpType)
        {
            case Power.Health:
                collider.GetComponent<Health>().IncrementHealth(5);
                break;
            case Power.Speed:
                break;
            case Power.Damage:
                break;
        }
        Destroy(gameObject);
    }
}
