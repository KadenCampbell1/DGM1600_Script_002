using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : MonoBehaviour {

    public NPCSpeechBubbles npcScript;
    public PlayerMovement playerScript;
    public MusicManager musicManager;

	
	void Start () {
        npcScript = GameObject.Find("NPCComputer").GetComponent<NPCSpeechBubbles>();
        playerScript = GetComponent<PlayerMovement>();
//        musicManager = GameObject.Find("Music Manager").GetComponent<MusicManager>();
	}


    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Item"))
        switch (npcScript.myNPC)
        {
            case NPCSpeechBubbles.npcLevel.Level01:
                playerScript.speed += 10;
                break;
            case NPCSpeechBubbles.npcLevel.Level02:
                playerScript.speed -= 5;
                break;
            case NPCSpeechBubbles.npcLevel.Level03:
                playerScript.healthScript.health += 1;
                break;
            case NPCSpeechBubbles.npcLevel.Level04:
                    playerScript.jump += 200;
                break;
            case NPCSpeechBubbles.npcLevel.Level05:
                    playerScript.speed += 20;
                break;
            case NPCSpeechBubbles.npcLevel.Level06:
                    playerScript.speed += 5;
                    playerScript.jump += 100;
                break;
            case NPCSpeechBubbles.npcLevel.Level07:
                    playerScript.speed -= 5;
                    playerScript.jump -= 100;
                break;
        }
    }
    
}
