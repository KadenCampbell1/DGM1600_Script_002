using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicManager : MonoBehaviour {

    //Singleton

    public static MusicManager instance = null;
    public AudioClip[] musicType;
    public AudioSource myAudioSource;
    //public AudioClip currentSong;
    public bool metalTime;
    public bool zerothExit;


  
    void Awake()
    {

        if (instance == null)                               //if instance is not assigned
        {                                                   //then assign instance to this object
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else if (instance != this)
        {
            Destroy(this.gameObject);                       //then destroy this object
        }

        myAudioSource = GetComponent<AudioSource>();
        //currentSong = myAudioSource.clip;
        //SwitchSong();
    }


    public void Jazz()
    {
        myAudioSource.clip = musicType[0];
        myAudioSource.Play();
        myAudioSource.volume = 0.5f;
    }

    public void Metal()
    {
        myAudioSource.clip = musicType[2];
        myAudioSource.Play();
        myAudioSource.volume = 0.2f;
    }


    /*
        private void Update()
        {


            if (metalTime)
            {
                myAudioSource.clip = musicType[1];

            }
            myAudioSource.Play();
            for (int i = 0; i <= myAudioSource.clip.length; i++)
            {
                if (i == myAudioSource.clip.length)
                {
                    i = 0;
                    if(myAudioSource.clip == musicType[1])
                    {
                        myAudioSource.clip = musicType[2];
                    }

                }
            }

        }
    */


    /* 

       private void SwitchSong()
       {
           myAudioSource.Stop();
           if (metalTime)
           {
               myAudioSource.clip = musicType[2];
             //
               if (myAudioSource.clip == musicType[1])
               {
                   myAudioSource.clip = musicType[2];
               }
               else
               {
                   myAudioSource.clip = musicType[2];
               }
             // 
           }
           else
           {
               myAudioSource.clip = musicType[0];
           }
           myAudioSource.Play();
       }
   */
}
