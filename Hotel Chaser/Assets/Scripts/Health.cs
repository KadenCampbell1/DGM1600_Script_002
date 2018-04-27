using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {


    public int health;
    public ParticleSystem deathParticle;
    public Camera afterDeathCamera;
    public Manager myManager;
    public Canvas deathCanvas;
    public Text livesText;

    private void Start()
    {
        myManager = FindObjectOfType<Manager>().GetComponent<Manager>();
        deathCanvas = GameObject.Find("DeathCanvas").GetComponent<Canvas>();
        deathCanvas.enabled = false;
        livesText.text = "Lives: " + health.ToString();
    }

    private void Update()
    {
        livesText.text = "Lives: " + health.ToString();
    }

    public void IncrementHealth(int amount)
    {
        
        health += amount;

        livesText.text = "Lives: " + health.ToString();

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
