using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    //public string level;
    public static Manager instance = null;

    void Awake()
    {
    //Screen.fullScreen = !Screen.fullScreen;
        if (instance == null)                               //if instance is not assigned
        {                                                   //then assign instance to this object
            instance = this;
        }

        else if (instance != this)
        {
            Destroy(this.gameObject);                       //then destroy this object
        }

        DontDestroyOnLoad(this.gameObject);
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
