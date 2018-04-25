using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {

    public int score;
    public Text scoreText;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        IncrementScore(1);
        Destroy(this.gameObject);
    }



    public void IncrementScore(int amount)
    {
        score += amount;

        scoreText.text = "Money: " + score;
    }
}
