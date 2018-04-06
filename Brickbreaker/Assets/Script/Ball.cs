using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {


    public AudioClip[] hitChoice;
    public Vector2 startVector;
    public int hitNumber = 0;

    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(startVector, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(hitChoice[hitNumber], new Vector3(0, 0, 0));

        hitNumber++;        //this line might have to be incremented and subtracted by one to get the correct number to play 
        if(hitNumber >= 3)                      //the number 3 is the amount of hit sounds there are
        {
            hitNumber = 0;
        }
    }

}
