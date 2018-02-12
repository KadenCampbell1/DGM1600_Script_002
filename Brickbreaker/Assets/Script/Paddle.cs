using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {


    
	void Update ()
    {
        //get current paddle position
        Vector3 paddlePosition = new Vector3(0, gameObject.transform.position.y, 0);

        //get mouse horizontal position
        float mouseX = Input.mousePosition.x / Screen.width * 16 - 8;
     
        paddlePosition.x = mouseX;

        //set this paddle to saved position
        //can have this. in front
        gameObject.transform.position = paddlePosition;
	}
}
