using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
    /*
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
    */
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
