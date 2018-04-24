using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {


    public float shootDistance;
    public float minDistance;
    public float maxDistance;
    public float shootTime;
    public bool lookLeft;
    public Color shootColor;
    private LineRenderer lineRenderer;
    private Animator anim;


    // Use this for initialization
    void Start () {
        lineRenderer = GetComponent<LineRenderer>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxisRaw("Horizontal") < -0.1f)
        {
            //flip sprite renderer
            lookLeft = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0.1f)
        {
            //unflip
            lookLeft = false;
        }

        if (Input.GetButton("Fire1"))
        {
            anim.SetTrigger("ShootGo");
            Shoot();
        }
    }

    public void Shoot()
    {
        Vector2 position = transform.position;
        //figure out direction
        Vector2 direction;
        if (lookLeft)
        {
            direction = Vector2.left;
            position += new Vector2(-0.5f, 0);
            lineRenderer.SetPosition(0, new Vector3(-0.5f, 0, 0));
            lineRenderer.SetPosition(1, new Vector3(-10.5f, 0, 0));
        }
        else
        {
            direction = Vector2.right;
            position += new Vector2(0.5f, 0);
            lineRenderer.SetPosition(0, new Vector3(0.5f, 0, 0));
            lineRenderer.SetPosition(1, new Vector3(10.5f, 0, 0));
        }
        Debug.DrawRay(position, direction, Color.red, 0.25f);
        lineRenderer.enabled = true;
        RaycastHit2D hit = Physics2D.Raycast(position, direction, shootDistance);
        if (hit.collider != null)
        {
            //deal damage
            Debug.Log(hit.collider.name);
            if (hit.collider.GetComponent<Health>())
            {
                hit.collider.GetComponent<Health>().IncrementHealth(-1);
            }
        }
        StartCoroutine(LazerOff());

    }

    IEnumerator LazerOff()
    {
        yield return new WaitForSeconds(shootTime);
        lineRenderer.enabled = false;
    }
}
