using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangesBackJazz : MonoBehaviour {


    public MusicManager myMusicManager;

	
	void Start ()
    {
        myMusicManager = GameObject.Find("MusicManager").GetComponent<MusicManager>();

        myMusicManager.Jazz();
	}
	
	

}
