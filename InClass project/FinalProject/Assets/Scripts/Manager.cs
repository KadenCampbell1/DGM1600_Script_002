using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    private static Manager instance = null;
    public Text scoreboard;
    private int score;
    public Text levelDisplay;
    public Text livesDisplay;
    public int lives;

    public void Awake()
    {
        if(instance == null)
        {
            instance = this.gameObject.GetComponent<Manager>();
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void IncrementScore(int value)
    {
        score += value;
        scoreboard.text = "Score: " + score.ToString();
    }

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);

        Debug.Log(MultiplyTwoFloats(3.5f, 2.6f));
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
	

    public float MultiplyTwoFloats(float one, float two)
    {
        float product = one * two;

        return product;
    }
}
