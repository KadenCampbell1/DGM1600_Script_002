using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableCanvas : MonoBehaviour {

    public Canvas otherCanvas;

	
	void Start ()
    {
        otherCanvas.enabled = true;
	}
	

}
