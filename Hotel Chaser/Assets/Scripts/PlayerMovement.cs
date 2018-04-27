using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rigid;
    public float jump;
    private bool isGrounded;
    public LayerMask groundLayer;
    public float speed;
    public bool sideScroll;
    private Animator anim;
    private SpriteRenderer rend;
    public Health healthScript;
    public Money moneyScript;
    public Manager myManager;

    // Use this for initialization
    void Start()
    {
        sideScroll = true;
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        healthScript = GetComponent<Health>();
        moneyScript = FindObjectOfType<Money>().GetComponent<Money>();
        myManager = FindObjectOfType<Manager>().GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        //myManager.IncrementScore(0);

        if (!sideScroll)
        {
            rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed), ForceMode2D.Force);
            anim.SetFloat("HorizontalGo", Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("VerticalGo", Input.GetAxisRaw("Vertical"));

            if (Input.GetAxisRaw("Horizontal") < -0.1f)
            {
                //flip sprite renderer
                rend.flipX = true;

            }
            else if (Input.GetAxisRaw("Horizontal") > 0.1f)
            {
                //unflip
                rend.flipX = false;
            }
        }
        else
        {
            rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);

            //  anim.SetFloat("HorizontalGo", Input.GetAxisRaw("Horizontal"));
            anim.SetFloat("HorizontalGo", Input.GetAxisRaw("Horizontal"));

            if (Input.GetAxisRaw("Horizontal") < -0.1f)
            {
                //flip sprite renderer
                rend.flipX = true;

            }
            else if (Input.GetAxisRaw("Horizontal") > 0.1f)
            {
                //unflip
                rend.flipX = false;
            }
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (IsGrounded())
            {
                rigid.AddForce(new Vector2(0, jump), ForceMode2D.Force);
            }


        }
    }


    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;

        Debug.DrawRay(position, direction, Color.green, 0.25f);
        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }
        return false;
    }


    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Boss"))
        {
            healthScript.Die();
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("DamageSurface"))
        {
            healthScript.IncrementHealth(-1);
        }
/*
        if (collider.gameObject.CompareTag("Money"))
        {
            //moneyScript.IncrementScore(1);
        }
*/
    }

}
