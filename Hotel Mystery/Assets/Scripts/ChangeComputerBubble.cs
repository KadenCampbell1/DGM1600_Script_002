﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeComputerBubble : MonoBehaviour {

    public Text textBubble;
    public int textNumber;

    private void Start()
    {
       if(textNumber == 0)
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
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (textNumber == 0)
        {
            textBubble.text = "There was a murder in the center of your lobby.\n" +
                "It is disturbing me... Could you take my stuff up to my room and report back?\n" +
                "There will be a reward in it for you.\n" +
                "It is room 110.\n" +
                "I want to get out of here as soon as possible.";

            //drop item that corrisponds to first computer and check for variable deservesReward to drop money
            // purse
            // for good bye text make it say "thanks I'll be heading out then"
            // use enable and disable to control where things spawn in
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
                "It is room 207. Come back after and I'll reward you.";

            //drop item that corrisponds to first computer and check for variable deservesReward to drop money
            //Backpack
        }

        if (textNumber == 3)
        {
            textBubble.text = "Ah, Lobby boy, I have don't have enough hands.\n" +
                "Would you mind carrying my BRIEFCASE to room 207 and let me know when it is done?";

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
            textBubble.text = "Oh good, Lobby boy, my room is 305.\n" +
                "Would you mind taking my BOOK to my room\n" +
                "and letting me know when you are done?\n" +
                "I would like to leave until this is cleaned up.";

            //drop item that corrisponds to first computer and check for variable deservesReward to drop money
            //Book
        }

        if (textNumber == 6)
        {
            textBubble.text = "Yo, Yo, Yo. Lobby boy I'm glad you shuffled over.\n" +
                "I need you to run my BOARD up to my room. \n" +
                "If you hurry and then come back I'll give you a reward.";

            //drop item that corrisponds to first computer and check for variable deservesReward to drop money
        }
    }
}
