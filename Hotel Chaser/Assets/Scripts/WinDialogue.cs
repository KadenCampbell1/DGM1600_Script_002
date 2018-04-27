using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinDialogue : MonoBehaviour {


    public Text dialodueText;
    public int dialogueNumber = 0;
    public Manager myManager;

    private void Start()
    {
        dialodueText.text = "Congratulations on completing my game.";
//        myManager = FindObjectOfType<GameObject>().GetComponent<Manager>();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogueNumber += 1;
        }

        if (dialogueNumber == 1)
        {
            dialodueText.text = "I hope you enjoyed playing.";
        }

        if (dialogueNumber == 2)
        {
            dialodueText.text = "Hotel Chaser will return in Hotel Mystery.";
        }

    }
}
