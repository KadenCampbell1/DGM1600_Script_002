using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBubbleTester : MonoBehaviour {

    public Canvas textBubbleCanvas;


    void Awake()
    {

        textBubbleCanvas = GameObject.Find("PlayerSpeechCanvas").GetComponent<Canvas>();               //finds object by name
        //textBubbleCanvas.enabled = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        textBubbleCanvas.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        textBubbleCanvas.enabled = false;
    }
}
