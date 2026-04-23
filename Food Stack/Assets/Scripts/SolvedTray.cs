using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolvedTray : MonoBehaviour
{
    // Start is called before the first frame update
    public List<FoodItems> items;
    public PuzzleMaster puzzle;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool checkIfCorrect(Tray tray)
    {
        if (tray.items.Count == items.Count)
        {
            Debug.Log("thru count check");
            for (int i = 0; i < items.Count; i++)
            {
                if (tray.items[i].foodName != items[i].foodName)
                {
                    return false;
                }
            }
            Debug.Log("thru name check");
            for (int i = 0; i < items.Count; i++)
            {
                if (tray.items[i].transform.position.x > (items[i].transform.position.x + 1.5) || tray.items[i].transform.position.x < (items[i].transform.position.x - 1.5) || tray.items[i].transform.position.y > (items[i].transform.position.y + 1.5) || tray.items[i].transform.position.y < (items[i].transform.position.y - 1.5))
                {
                    return false;
                }
            }
            Debug.Log("thru pos check");
            return true;
        } else
        {
            return false;
        }
    }
}
