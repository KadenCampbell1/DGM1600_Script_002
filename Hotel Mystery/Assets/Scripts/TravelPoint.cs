using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelPoint : MonoBehaviour {

    private Manager theManager;
    private string levelManger;
    public enum Location { Lobby, Floor1, Floor2, Floor3};
    public Location myLocation;
    public int floorNumber;

    private void Start()
    {
        theManager = FindObjectOfType<Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        switch (myLocation)
        {
            case Location.Lobby:
                if (Input.GetKeyDown(KeyCode.T)) { Debug.Log(myLocation); }
                levelManger = "Level01";
                break;
            case Location.Floor1:
                levelManger = "Level02";
                break;
            case Location.Floor2:
                levelManger = "Level03";
                break;
            case Location.Floor3:
                levelManger = "Level04";
                break;
        }
        theManager.LoadLevel(levelManger);
    }

}
