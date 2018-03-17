using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    /*
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    */

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
