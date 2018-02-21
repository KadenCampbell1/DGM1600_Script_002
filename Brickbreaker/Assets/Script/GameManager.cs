using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    public static int brickCount;
    //Singleton
    public static GameManager instance = null;

    // Use this for initialization
    void Awake()
    {
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

    /*
      types of variables bool, int, float, string
    */

    public void LoadLevel(string level)
    {
        brickCount = 0;
        SceneManager.LoadScene(level);
    }

    public void LoadNextLevel()
    {
        brickCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
