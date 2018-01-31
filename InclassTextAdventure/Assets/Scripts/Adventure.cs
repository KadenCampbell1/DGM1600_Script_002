using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Adventure : MonoBehaviour
{

    public enum States { cell, gate, window, bed};
    public States currentState;
    public Text textObject;
    public Text titleObject;

    // Use this for initialization
    void Start ()
    {
        currentState = States.bed;
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (currentState == States.cell)
        {
            Cell();
        }
        else if (currentState == States.gate)
        {
            Gate();
        }
        else if (currentState == States.window)
        {
            Window();
        }
        else if (currentState == States.bed)
        {
            Bed();
        }

    }

    private void Bed()
    {
        /*
        print("You are at your Bed. It is very dark. \n" +
           "There is a Window. \n" +
           "There is the center of your Cell. \n" +
           "There is a Bed. \n" +
           "There is the Gate of your cell. \n" +
           "Press W for window, G for Gate, C for Cell, B for Bed.");
        */
        titleObject.text = "Bed";
        textObject.text = "You are at your Bed. It is very dark. \n" +
           "There is a Window. \n" +
           "There is the center of your Cell. \n" +
           "There is a Bed. \n" +
           "There is the Gate of your cell. \n" +
           "Press W for window, G for Gate, C for Cell, B for Bed.";
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
    }

    private void Window()
    {
         /*
        print("You are at a Window. It is very dark and dark outside. \n" +
           "There is a Window. \n" +
           "There is the center of your Cell. \n" +
           "There is a Bed. \n" +
           "There is the Gate of your cell. \n" +
           "Press W for window, G for Gate, C for Cell, B for Bed.");
         */
        titleObject.text = "Window";
        textObject.text = "You are at a Window. It is very dark and dark outside. \n" +
           "There is a Window. \n" +
           "There is the center of your Cell. \n" +
           "There is a Bed. \n" +
           "There is the Gate of your cell. \n" +
           "Press W for window, G for Gate, C for Cell, B for Bed.";
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }

    private void Gate()
    {
         /*
        print("You are at an iron Gate. It is very dark. \n" +
           "There is a Window. \n" +
           "There is the center of your Cell. \n" +
           "There is a Bed. \n" +
           "There is the Gate of your cell. \n" +
           "Press W for window, G for Gate, C for Cell, B for Bed.");
         */
        titleObject.text = "Gate";
        textObject.text = "You are at an iron Gate. It is very dark. \n" +
           "There is a Window. \n" +
           "There is the center of your Cell. \n" +
           "There is a Bed. \n" +
           "There is the Gate of your cell. \n" +
           "Press W for window, G for Gate, C for Cell, B for Bed.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.C)) { currentState = States.cell; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }

    private void Cell()
    {
         /*
        print("You are in an old Cell. It is very dark. \n" +
            "There is a Window. \n" +
            "There is a Gate. \n" +
            "There is a Bed. \n" +
            "Press W for window, G for Gate, B for Bed.");
         */
        titleObject.text = "Cell";
        textObject.text = "You are in an old Cell. It is very dark. \n" +
            "There is a Window. \n" +
            "There is a Gate. \n" +
            "There is a Bed. \n" +
            "Press W for window, G for Gate, B for Bed.";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.window; }
        if (Input.GetKeyDown(KeyCode.G)) { currentState = States.gate; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.bed; }
    }



    //youtube music archive
    //https://www.youtube.com/audiolibrary/music
    //sprite creator
    //https://www.piskelapp.com/

}
