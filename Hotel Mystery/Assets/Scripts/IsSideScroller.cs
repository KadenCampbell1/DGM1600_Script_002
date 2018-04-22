using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsSideScroller : MonoBehaviour {

    public PlayerMovement playerScript;

	// Use this for initialization
	void Start () {

        playerScript = FindObjectOfType<PlayerMovement>();
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerScript.sideScroll = true;
    }
}
