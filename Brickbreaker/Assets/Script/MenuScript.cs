using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
    public Text title;
    public Text startButton;
    public Text quitButton;
	// Use this for initialization
	void Start () {
        title.text = "Brick Breaker!";
        startButton.text = "Play";
        quitButton.text = "Quit";
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
