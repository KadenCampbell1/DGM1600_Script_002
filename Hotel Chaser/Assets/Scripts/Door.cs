using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour {

    public Canvas theCanvas;

    
    void Awake ()
    {
        theCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();               //finds object by name
        theCanvas.enabled = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        theCanvas.enabled = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        theCanvas.enabled = false;
    }
    
}
