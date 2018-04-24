using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemState : MonoBehaviour {

    public int power;
    public bool isCarried;
    public bool isDelivered;
    public string Something;


	// Use this for initialization
	void Start () {
        Manager.SaveEvent += SaveFunction;
        Manager.LoadEvent += LoadFunction;
	}

    private void OnDestroy()
    {
        Manager.SaveEvent -= SaveFunction;
        Manager.LoadEvent -= LoadFunction;
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void SaveFunction(object sender, EventArgs args)
    {
        ItemStatistics itemStat = new ItemStatistics();
        itemStat.isCarried = this.isCarried;
        itemStat.isDelivered = this.isDelivered;
        itemStat.name = this.name;

        Manager.instance.itemList.Add(itemStat);
    }

    public void LoadFunction(object sender, LoadEventArgs args)
    {
        ItemStatistics itemStat = args.item;
        
        if(itemStat.name == this.name)
        {
            this.isCarried = itemStat.isCarried;
            this.isDelivered = itemStat.isDelivered;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            isCarried = true;
            this.GetComponent<Renderer>().enabled = false;
        }
    }
}
