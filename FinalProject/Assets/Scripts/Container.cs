using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour {


    public GameObject[] items;

    public void Drop()
    {
        for (int i = 0; i < items.Length; i++)
        {
            GameObject item = Instantiate(items[i], gameObject.transform.position, Quaternion.identity);
            //make sure item has rigidbody
            if (!item.GetComponent<Rigidbody2D>())
            {
                item.AddComponent<Rigidbody2D>();
            }
            //make sure item collider is not trigger
            if (!item.GetComponent<Collider2D>())
            {
                item.AddComponent<CapsuleCollider2D>();
            }
            else
            {
                item.GetComponent<Collider2D>().isTrigger = false;
            }
        }

    }
}
