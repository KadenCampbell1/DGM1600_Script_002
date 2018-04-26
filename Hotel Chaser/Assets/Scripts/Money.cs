using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {

    private Manager myManager;
    public int value;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        myManager.IncrementScore(value);
        Destroy(gameObject);
    }
}
