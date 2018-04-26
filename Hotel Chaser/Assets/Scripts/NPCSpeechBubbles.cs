using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCSpeechBubbles : MonoBehaviour
{

    public Text textBubble;
//    public int textNumber;
    public GameObject item;
    public enum npcLevel { Level01, Level02, Level03, Level04, Level05, Level06, Level07 };
    public npcLevel myNPC;
    public bool isCarrying;


    private void Start()
    {
        if (item != null)
        {
            item.GetComponent<Renderer>().enabled = false;
        }

        switch (myNPC)
        {
            case npcLevel.Level01:
                textBubble.text = "Excuse me, Lobby boy.";
                break;
            case npcLevel.Level02:
                textBubble.text = "Oh Sonny, I need some help.";
                break;
            case npcLevel.Level03:
                textBubble.text = "Lobby boy\n" +
                "Lobby boy\n" +
                "Lobby boy";
                break;
            case npcLevel.Level04:
                textBubble.text = "Hey, Lobby boy.";
                break;
            case npcLevel.Level05:
                textBubble.text = "Hey, yo bud.";
                break;
            case npcLevel.Level06:
                textBubble.text = "Excuse me, could you help me.";
                break;
            case npcLevel.Level07:
                textBubble.text = "Yo, Lobby boy.";
                break;
        }

        /*
                if (textNumber == 0)
                {
                    textBubble.text = "Excuse me, Lobby boy.";
                }

                if (textNumber == 1)
                {
                    textBubble.text = "Oh Sonny, I need some help.";
                }

                if (textNumber == 2)
                {
                    textBubble.text = "Lobby boy\n" +
                        "Lobby boy\n" +
                        "Lobby boy";
                }

                if (textNumber == 3)
                {
                    textBubble.text = "Hey, Lobby boy.";
                }

                if (textNumber == 4)
                {
                    textBubble.text = "Yo, Lobby boy.";
                }

                if (textNumber == 5)
                {
                    textBubble.text = "Excuse me, could you help me.";
                }

                if (textNumber == 6)
                {
                    textBubble.text = "Hey, yo bud.";
                }

                if (textNumber == 7)
                {
                    textBubble.text = "Hello, it is I, the creator. \n" +
                        "My name is Kaden. Thank you for finding me.\n" +
                        "I have a gift for you.";
                }

                if (textNumber == 8)
                {
                    textBubble.text = "Psst. Hey you.\n" +
                        "He is a liar.";
                }
        */

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (item != null)
        {
            if (!isCarrying)
            {
                item.GetComponent<Renderer>().enabled = true;
            }
            else
            {
                item.GetComponent<Renderer>().enabled = false;
            }
            
        }


        switch (myNPC)
        {
            case npcLevel.Level01:

                textBubble.text = "Will you take my PURSE to my room? \n" +
                    "It is room 200 just straight ahead. \n" +
                    "It will make you faster.\n" +
                    "Thanks Lobby boy";
                break;
            case npcLevel.Level02:
                textBubble.text = "Thank you for coming over.\n" +
                "My LUGGAGE is pretty heavy and I can't move it.\n" +
                "Could you take it to room 201? It is just straight ahead." +
                "It will weigh you down.";
                break;
            case npcLevel.Level03:
                textBubble.text = "If you would go and take my BACKPACK to my room.\n" +
               "It is room 202 just straight ahead. Thank you.\n" +
               "It will give you an extra ''Fall''.";
                break;
            case npcLevel.Level04:
                textBubble.text = "Ah, Lobby boy, I have don't have enough hands.\n" +
               "Would you mind carrying my BRIEFCASE to room 203? It is just straight ahead.\n" +
               "It will increase your jump height.";
                break;
            case npcLevel.Level05:
                textBubble.text = "Yo, Yo, Yo. Lobby boy I'm glad you shuffled over.\n" +
                "I need you to run my BOARD to my room 206.\n" +
                "It will make you really fast.";
                break;
            case npcLevel.Level06:
                textBubble.text = "Oh good, Lobby boy, my room is 205.\n" +
                "Would you mind taking my BOOK to my room?" +
                " It is just straight ahead.\n" +
                "It will increase your speed and jump height.";
                break;
            case npcLevel.Level07:
                textBubble.text = "Can you take my SUIT to room 204? It is just staight ahead.\n" +
                "I don't want it to wrinkle. Thanks my boy.\n" +
                "It will decrease your speed and jump height.";
                break;
        }
/*
                if (textNumber == 0)
                {
                    textBubble.text = "There was a murder in the center of your lobby.\n" +
                        "It is disturbing me... Could you take my stuff up to my room and report back?\n" +
                        "There will be a reward in it for you. " +
                        "It is room 105.\n" +
                        "The elevators are at the top of the room past the dead body.";

                    //drop item that corrisponds to first computer and check for variable deservesReward to drop money
                    // purse
                    // for good bye text make it say "thanks I'll be heading out then"
                    // use enable and disable to control where things spawn in

                    if (item != null)
                    {
                        if (!item.GetComponent<ItemState>().isCarried)
                        {
                            item.GetComponent<Renderer>().enabled = true;
                        }

                    }
                }

                if (textNumber == 1)
                {
                    textBubble.text = "Thank you for coming over.\n" +
                        "My LUGGAGE is pretty heavy and I can't move it.\n" +
                        "Could you take it to room 303 and report back.";

                    //drop item that corrisponds to first computer and check for variable deservesReward to drop money
                    //luggage
                }

                if (textNumber == 2)
                {
                    textBubble.text = "If you would go and take my BACKPACK to my room.\n" +
                        "It is room 205. Come back after and I'll reward you.";

                    //drop item that corrisponds to first computer and check for variable deservesReward to drop money
                    //Backpack
                }

                if (textNumber == 3)
                {
                    textBubble.text = "Ah, Lobby boy, I have don't have enough hands.\n" +
                        "Would you mind carrying my BRIEFCASE to room 205 and let me know when it is done?";

                    //drop item that corrisponds to first computer and check for variable deservesReward to drop money
                    //check if it is done when they enter to change text then when they leave change to a "finished" text that doesn't change (maybe disable the 2dcolider)
                    //briefcase
                    //when the mission is done change to "Later"
                }

                if (textNumber == 4)
                {
                    textBubble.text = "Can you take my SUIT to room 101?\n" +
                        "I don't want it to wrinkle. Thanks my boy.\n" +
                        "Let me know when you're done and I'll give you something.";

                    //drop item that corrisponds to first computer and check for variable deservesReward to drop money
                    //suit
                }

                if (textNumber == 5)
                {
                    textBubble.text = "Oh good, Lobby boy, my room is 304.\n" +
                        "Would you mind taking my BOOK to my room" +
                        "and letting me know when you are done?\n" +
                        "I would like to leave until this is cleaned up.";

                    //drop item that corrisponds to first computer and check for variable deservesReward to drop money
                    //Book
                }

                if (textNumber == 6)
                {
                    textBubble.text = "Yo, Yo, Yo. Lobby boy I'm glad you shuffled over.\n" +
                        "I need you to run my BOARD up to my room 203. \n" +
                        "If you hurry and then come back I'll give you a reward.";

                    //drop item that corrisponds to first computer and check for variable deservesReward to drop money
                    //skateboard
                }
*/
    }

}
