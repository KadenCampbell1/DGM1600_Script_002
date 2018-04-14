using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossTest : MonoBehaviour {

    public Manager myManager;
    public Text myText;
    public bool isStrong;
    public string Level;

    private void Start()
    {
        myManager = FindObjectOfType<Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isStrong)
        {
            myText.text = "You have found the Murderer's hideout. Enter if you dare.";
        }
        else
        {
            myText.text = "You are not powerful enough to enter. Help out more customers.";
            myManager.LoadLevel(Level);
        }
        
    }
}
