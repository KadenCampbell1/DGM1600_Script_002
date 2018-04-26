using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {


    public int health;
    public ParticleSystem deathParticle;
    public Camera afterDeathCamera;
    public Manager myManager;
    public Canvas deathCanvas;

    private void Start()
    {
        myManager = FindObjectOfType<Manager>().GetComponent<Manager>();
        deathCanvas = GameObject.Find("DeathCanvas").GetComponent<Canvas>();
        deathCanvas.enabled = false;
    }

    public void IncrementHealth(int amount)
    {
        health += amount;

        if (health <= 0)
        {
            Die();
        }
    }



    public void Die()
    {
        if (afterDeathCamera != null)
        {
            Camera deathCamera = Instantiate(afterDeathCamera, gameObject.transform.position, Quaternion.identity);
        }
        
        Destroy(gameObject);

        if (deathParticle != null)
        {
            ParticleSystem particle = Instantiate(deathParticle, gameObject.transform.position, Quaternion.identity);
            Destroy(particle, particle.main.duration);
        }


        deathCanvas.enabled = true;
    }
}
