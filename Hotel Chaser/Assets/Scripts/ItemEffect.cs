using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : MonoBehaviour {

    public NPCSpeechBubbles npcScript;
    public PlayerMovement playerScript;
    public MusicManager musicManager;

	
	void Start () {
        npcScript = GameObject.Find("NPCComputer").GetComponent<NPCSpeechBubbles>();
        playerScript = GameObject.Find("Player 1").GetComponent<PlayerMovement>();
        musicManager = GameObject.Find("MusicManager").GetComponent<MusicManager>();
	}


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        switch (npcScript.myNPC)
        {
            case NPCSpeechBubbles.npcLevel.Level01:
                playerScript.speed += 10;
                Destroy(this.gameObject);
                break;
            case NPCSpeechBubbles.npcLevel.Level02:
                playerScript.speed -= 3;
                Destroy(this.gameObject);
                break;
            case NPCSpeechBubbles.npcLevel.Level03:
                playerScript.healthScript.health += 1;
                Destroy(this.gameObject);
                break;
            case NPCSpeechBubbles.npcLevel.Level04:
                playerScript.jump += 200;
                Destroy(this.gameObject);
                break;
            case NPCSpeechBubbles.npcLevel.Level05:
                playerScript.speed += 20;
                musicManager.Metal();
                Destroy(this.gameObject);
                    break;
            case NPCSpeechBubbles.npcLevel.Level06:
                playerScript.speed += 5;
                playerScript.jump += 100;
                musicManager.Jazz();
                Destroy(this.gameObject);
                break;
            case NPCSpeechBubbles.npcLevel.Level07:
                playerScript.speed -= 5;
                playerScript.jump -= 70;
                playerScript.healthScript.health += 7;
                Destroy(this.gameObject);
                break;
        }
    }
    
}
