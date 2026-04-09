using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tray : MonoBehaviour
{
    // Start is called before the first frame update
    public List<FoodItems> items;
    void Start()
    {
        items = new List<FoodItems>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToTray(FoodItems item)
    {
        if (!items.Contains(item))
        {
            items.Add(item);
        } else
        {
            Debug.Log("Item already in Tray");
        }
        
    }

    public void RemoveFromTray(FoodItems item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
    }
}
