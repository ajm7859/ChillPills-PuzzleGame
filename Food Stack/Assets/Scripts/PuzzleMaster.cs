using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.IK;

public class PuzzleMaster : MonoBehaviour
{
    // Start is called before the first frame update
    public Tray tray;
    public List<String> answer;
    public bool solved = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isSolved();
    }

    public bool isSolved()
    {
        if (tray.items.Count == answer.Count)
        {
            for (int i = 0; i < tray.items.Count; i++)
            {
                if (tray.items[i].getString() != answer[i])
                {
                    solved = false;
                    return false;
                } 
            }
            solved = true;
            return true;
        } else
        {
            solved = false;
            return false;
        }
    }
}
