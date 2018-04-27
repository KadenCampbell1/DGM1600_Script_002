using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueScript : MonoBehaviour {

    public Text dialodueText;
    public int dialogueNumber = 0;
    public Manager myManager;

    private void Start()
    {
        dialodueText.text = "Boss: Oh, Lobby Boy, how good to see you.";
//      myManager = FindObjectOfType<GameObject>().GetComponent<Manager>();
        myManager = GameObject.Find("GameManager").GetComponent<Manager>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogueNumber += 1;
        }

        if (dialogueNumber == 1)
        {
            dialodueText.text = "Lobby Boy: Boss, I'm glad I ran into you. Did you see a mysterious person running by? They murdered someone and they need to be arrested.";
        }

        if (dialogueNumber == 2)
        {
            dialodueText.text = "Boss: You saw a murder? Now that you mention it, there was an individual that just got in a taxi and drove off.";
        }

        if (dialogueNumber == 3)
        {
            dialodueText.text = "Lobby Boy: Blast, did you hear where they were going?";
        }

        if (dialogueNumber == 4)
        {
            dialodueText.text = "Boss: No, I did not.";
        }

        if (dialogueNumber == 5)
        {
            dialodueText.text = "Lobby Boy: Well, I guess we will have to keep an eye out.";
        }

        if (dialogueNumber == 6)
        {
            dialodueText.text = "Boss: Yes, let's watch for a mysterious person.";
        }

        if (dialogueNumber == 7)
        {
            myManager.LoadLevel("LevelWin");
        }

    }

}
