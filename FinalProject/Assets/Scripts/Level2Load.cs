using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(BoxCollider2D))]

public class Level2Load : MonoBehaviour {

    private Manager manager;
    public string level;

    private void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Manager>();
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.GetComponent<PlayerMovement>())
        {
            //change level
            manager.LoadLevel(level);
        }
    }
}
