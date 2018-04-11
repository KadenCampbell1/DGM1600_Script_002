using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rigid;
    public float speed;

    private void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") *speed), ForceMode2D.Force);
    }
    
}
