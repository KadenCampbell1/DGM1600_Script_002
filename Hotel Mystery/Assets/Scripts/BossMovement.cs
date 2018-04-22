using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour {

    public Vector2 startVector;
    public Health healthScript;
    public ItemDamageOutput itemDamage;

    // Use this for initialization
    void Start ()
    {
        GetComponent<Rigidbody2D>().AddForce(startVector, ForceMode2D.Force);
        healthScript = GetComponent<Health>();
        itemDamage = FindObjectOfType<Manager>().GetComponent<ItemDamageOutput>();
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.CompareTag("Weapon"))
        healthScript.IncrementHealth(itemDamage.damage);

        //needs to access the other object
        
    }
}
