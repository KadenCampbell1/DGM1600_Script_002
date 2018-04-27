using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBubbleTester : MonoBehaviour {

    public Canvas textBubbleCanvas;


    void Awake()
    {
        if(GameObject.Find("PlayerSpeechCanvas").GetComponent<Canvas>() != null)
        {
            textBubbleCanvas = GameObject.Find("PlayerSpeechCanvas").GetComponent<Canvas>();             //finds object by name
        }return;
         
        //textBubbleCanvas.enabled = false;
    }


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("BubbleBound"))
        {
            textBubbleCanvas.enabled = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("BubbleBound"))
        {
            textBubbleCanvas.enabled = false;
        }
    }
}
