using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollision : MonoBehaviour {

    public NPCSpeechBubbles myNpcScript;
    public Renderer itemRenderer;
    private enum ItemName { Purse, Luggage, Backpack, Briefcase, Suit, Book, Skateboard };
    private ItemName myItem;

    private void Start()
    {
        myNpcScript = GameObject.Find("NPCComputer").GetComponent<NPCSpeechBubbles>();
        itemRenderer = myNpcScript.item.GetComponent<Renderer>();       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myNpcScript.isCarrying = true;
        itemRenderer.enabled = false;
    }
}


// make them choose 3 items to take with them at the boss fight. 
//stop the time and have each button add one to a 3 count and 
//change a bool to be checked with if statements and when the count
//is 3 hide the canvas and start the gametime. 