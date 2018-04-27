using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public static Manager instance = null;
    public int score;
    public Text scoreText;

    void Awake()
    {

        //Screen.fullScreen = !Screen.fullScreen;
        if (instance == null)                               //if instance is not assigned
        {                                                   //then assign instance to this object
            instance = this;

            DontDestroyOnLoad(this.gameObject);


        }

        else if (instance != this)
        {
            Destroy(this.gameObject);                       //then destroy this object
        }
    }
/*
    private void Update()
    {
        scoreText.text = "Money: " + score.ToString();
    }
*/
    public void IncrementScore(int value)
    {
        score += value;
        scoreText.text = "Money: " + score.ToString();
    }

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();

    }
}
