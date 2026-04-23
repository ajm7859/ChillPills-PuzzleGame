using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItems : MonoBehaviour
{
    // Start is called before the first frame update
    public Tray tray;
    public String foodName;

    public int index;
    void Start()
    {
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (tray.items.Contains(gameObject.GetComponent<FoodItems>()))
        {
            for (int i = 0; i < tray.items.Count; i++)
        {
            if (gameObject.GetComponent<FoodItems>().foodName == tray.items[i].foodName)
            {
                gameObject.GetComponent<SpriteRenderer>().sortingOrder = i+1;
            }
        }
        } else
        {
           gameObject.GetComponent<SpriteRenderer>().sortingOrder = index; 
        }
        
        
    }

    public String getString()
    {
        return foodName;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("collided");
        if (collision.gameObject.tag == "Tray")
        {
            Debug.Log("collided");
            tray.AddToTray(gameObject.GetComponent<FoodItems>());
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        //Debug.Log("collided");
        if (collision.gameObject.tag == "Tray")
        {
            Debug.Log("leaving");
            tray.RemoveFromTray(gameObject.GetComponent<FoodItems>());
        }
    }
}
