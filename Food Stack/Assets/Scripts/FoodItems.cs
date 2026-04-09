using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodItems : MonoBehaviour
{
    // Start is called before the first frame update
    public Tray tray;
    public String foodName;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
