using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueScene : MonoBehaviour {

    public Text dialodueText;
    public int dialogueNumber = 0;
    public Manager myManager;

    private void Start()
    {
        dialodueText.text = "Boss: I figured it would come to this. You were always my best worker.";
        myManager = FindObjectOfType<GameObject>().GetComponent<Manager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dialogueNumber += 1;
        }

        if(dialogueNumber == 1)
        {
            dialodueText.text = "Lobby boy: How could you do this? I worked for you for years, we were friends.";
        }

        if (dialogueNumber == 2)
        {
            dialodueText.text = "Boss: If I don't take a life every month, I will enter a state of madness and go on a killing spree. It wouldn't stop " +
                "until I murdered one hundred people.";
        }

        if (dialogueNumber == 3)
        {
            dialodueText.text = "Lobby boy: Is that why so many people have gone missing?";
        }

        if (dialogueNumber == 4)
        {
            dialodueText.text = "Boss: Yes, I have to kill, to save eveyone from my destructive ways.";
        }

        if (dialogueNumber == 5)
        {
            dialodueText.text = "Lobby boy: That doesn't make sense. It is all in your head. We can get help through therapy. You don't have to kill anyone.";
        }

        if (dialogueNumber == 6)
        {
            dialodueText.text = "Boss: You don't unstand --";
        }

        if (dialogueNumber == 7)
        {
            dialodueText.text = " I am not of this world. ";
        }

        if(dialogueNumber == 8)
        {
            dialodueText.text = " Mere therapy can't help me. ";
        }

        if (dialogueNumber == 9)
        {
            dialodueText.text = "Lobby boy: Listen to what are you saying. It's crazy, of course" +
                " you are from earth. Therapy helps people all the time. You are no exception.";
        }

        if (dialogueNumber == 10)
        {
            dialodueText.text = "Boss: Didn't you ever notice how big I am? I can't be human.";
        }

        if (dialogueNumber == 11)
        {
            dialodueText.text = "Lobby boy: Who wouldn't notice something like that. It is just acromegaly, a human disorder." +
                " You're fine let's get help.";
        }

        if (dialogueNumber == 12)
        {
            dialodueText.text = "Boss: That is why I liked you so much. You always tried to help me, but I am telling the truth." +
                " Let me show you.";
        }

        if (dialogueNumber == 13)
        {
            dialodueText.text = "...";

            //start Boss animation
        }

        if (dialogueNumber == 14)
        {
            dialodueText.text = "Boss: You see. It cannot be helped. You will have to kill me to stop me.";
        }

        if (dialogueNumber == 15)
        {
            dialodueText.text = "Lobby boy: I guess there is no avoiding it. I have to save the hotel and humanity.";
        }

        if (dialogueNumber == 16)
        {
            dialodueText.text = "You have helped deliver the " + ".\n" +
                "You can use them in battle.";

            //check for items delivered and maybe you can + if statements so do 
            //"you helped deliver the " + if(itemWhatever *bool of that item*){"ItemWhatever, "} +...
        }

        if (dialogueNumber == 17)
        {
            myManager.LoadLevel("Level07");
        }
    }
}


// when boss health equals 0 go to new level with dialogue "Thank you lobby boy. Please as a last wish bury me outside"
//then spacebar it goes to the drawing of the menu zoomed in and brown particles flash on and off from the bottom right of screen 
//then load new menu level with tombstone next to the hotel. With replay botton.
