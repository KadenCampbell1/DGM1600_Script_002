using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rigid;
    public float speed;
    public bool sideScroll;
    private Animator anim;
    private SpriteRenderer rend;
    public Health healthScript;
    public ItemDamageOutput itemDamage;

    private void Start()
    {
        sideScroll = false;
        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        rend = GetComponent<SpriteRenderer>();
        healthScript = GetComponent<Health>();
        if(FindObjectOfType<Manager>().GetComponent<ItemDamageOutput>() != null)
        {
            itemDamage = FindObjectOfType<Manager>().GetComponent<ItemDamageOutput>();
        }
    }
    private void Update()
    {
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
    }

    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.CompareTag("Boss"))
        {
            healthScript.Die();
        }
        if (collider.gameObject.CompareTag("BossWeapon"))
        {
            healthScript.IncrementHealth(itemDamage.damage);
        }
    }

}
