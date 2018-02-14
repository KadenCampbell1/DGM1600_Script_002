using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public bool autoPlay;
    private GameObject ball;


    private void Start()
    {
        ball = FindObjectOfType<Ball>().gameObject;

    }

    void Update ()
    {
        //get current paddle position
        Vector3 paddlePosition = new Vector3(0, gameObject.transform.position.y, 0);

        if (autoPlay)
        {
            paddlePosition.x = ball.transform.position.x;
        }
        else
        {
            float mouseX = Input.mousePosition.x / Screen.width * 16 - 8;

            paddlePosition.x = mouseX;
        }
        //get mouse horizontal position
        

        //set this paddle to saved position
        //can have this. in front
        gameObject.transform.position = paddlePosition;
	}
}
