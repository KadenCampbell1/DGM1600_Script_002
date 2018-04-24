using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;


public class LoadEventArgs : EventArgs
{
    public ItemStatistics item;
}

public class Manager : MonoBehaviour {

    //public string level;
    public static Manager instance = null;
    public List<ItemStatistics> itemList = new List<ItemStatistics>();
   
    public delegate void SaveDelegate(object sender, EventArgs args);
    public static event SaveDelegate SaveEvent;

    public delegate void LoadDelegate<LoadEventArgs>(object sender, LoadEventArgs args);
    public static event LoadDelegate<LoadEventArgs> LoadEvent;

    void Awake()
    {

    //Screen.fullScreen = !Screen.fullScreen;
        if (instance == null)                               //if instance is not assigned
        {                                                   //then assign instance to this object
            instance = this;

            DontDestroyOnLoad(this.gameObject);


        }

        else if (instance != this)
        {
            Destroy(this.gameObject);                       //then destroy this object
        }
    }


    public void FireSaveEvent()
    {
        if (SaveEvent != null)
        {
            SaveEvent(null, null);
        }
    }   

    public void FireLoadEvent(ItemStatistics itemStat)
    {
        if(LoadEvent != null)
        {
            LoadEventArgs args = new LoadEventArgs();
            args.item = itemStat;
            LoadEvent(this, args);
        }
    }
    
    public void SaveItems()
    {
        Manager.instance.itemList.Clear();
        FireSaveEvent();

        /*
         *    List<ItemStatistics> saveStats = saveStats = new List<ItemStatistics>();
      foreach (GameObject gameObject in itemList)
      {
          if (gameObject == null)
          {
              continue;
          }

          ItemStatistics itemStat = new ItemStatistics();
          itemStat.name = gameObject.name;
          itemStat.isCarried = gameObject.GetComponent<ItemState>().isCarried;
          itemStat.isDelivered = gameObject.GetComponent<ItemState>().isDelivered;


          saveStats.Add(itemStat);
      }

                      for (int i = 0; i < itemList.Length; i++)
                      {
                          GameObject gameObject = itemList[i];
                      }

                      IEnumerator e = itemList.GetEnumerator();
                      while (e.MoveNext() && e.Current != null)
                      {
                          ItemStatistics itemStat = new ItemStatistics();
                          GameObject gameObject = (GameObject)e.Current;
                          //itemStat.name = e.Current
                      }
      */

        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/itemStats.dat");
        bf.Serialize(file, Manager.instance.itemList);
        file.Close();

            
    }

    public void LoadData()
    {
        if (!File.Exists(Application.persistentDataPath + "/itemStats.dat"))
        {
            return;
        }


        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/itemStats.dat", FileMode.Open);
        Manager.instance.itemList = (List<ItemStatistics>)bf.Deserialize(file);
        file.Close();
       File.Delete(Application.persistentDataPath + "/itemStats.dat");

        foreach (ItemStatistics itemStat in Manager.instance.itemList)
        {
            FireLoadEvent(itemStat);
        }  

    }


    public void LoadLevel(string level)
    {
        SaveItems();
        SceneManager.LoadScene(level);
    }

    public void QuitGame()
    {
        if(File.Exists(Application.persistentDataPath + "/itemStats.dat"))
        {
            File.Delete(Application.persistentDataPath + "/itemStats.dat");
        }
     
        Debug.Log("Quit Game");
        Application.Quit();


    }
}
