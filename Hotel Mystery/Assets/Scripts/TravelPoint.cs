using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TravelPoint : MonoBehaviour {

    private Manager theManager;
    private string levelManger;
    public Canvas theCanvas;
    public Text button1Text;
    public Text button2Text;
    public Text button3Text;
    public enum Location { Lobby, Floor1, Floor2, Floor3};
    public Location myLocation;
    public int floorNumber;
    public Button myButton1;
    public Button myButton2;
    public Button myButton3;


    private void Awake()
    {
        theManager = FindObjectOfType<Manager>();
        theCanvas = FindObjectOfType<Canvas>();
        theCanvas.enabled = false;
        
        /*
        myButton1 = FindObjectOfType<Button>();
        button1Text = FindObjectOfType<Text>();
        button2Text = FindObjectOfType<Text>();
        button3Text = FindObjectOfType<Text>();
        */

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (myLocation)
        {
            case Location.Lobby:
                button1Text.text = "Floor 1";                                   //manually make buttons on each level instead of changing them through code
                button2Text.text = "Floor 2";
                button3Text.text = "Floor 3";
           //     levelManger = "Level02";                                      //brackeys
                break;
            case Location.Floor1:
                button1Text.text = "Lobby";
                button2Text.text = "Floor 2";
                button3Text.text = "Floor 3";
                break;
            case Location.Floor2:
                button1Text.text = "Lobby";
                button2Text.text = "Floor 1";
                button3Text.text = "Floor 3";
                break;
            case Location.Floor3:
                button1Text.text = "Lobby";
                button2Text.text = "Floor 1";
                button3Text.text = "Floor 2";
                break;
        }
        theCanvas.enabled = true;

        theManager.LoadLevel(levelManger);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        theCanvas.enabled = false;
    }

}


//use the switch for item damage in the boss fight
//use UI canvas to keep track of clues in the upper right corner or objective
