using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackDamage : MonoBehaviour {

    public Health healtScript;
	
	void Start ()
    {
        healtScript = GameObject.Find("Player").GetComponent<Health>();
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        healtScript.IncrementHealth(-1);
    }

}
