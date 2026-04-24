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

    public int numberOfItems;

    public int currentIndex;

    public SolvedTray solvedTray;

    public LevelUIManager levelUIManager;

    private bool completionShown = false;

    /*
    when an item is clicked, change the sorting order to be one more than the current index?
    or specifically when an item is dropped on tray
    sorting order is plus one when an object collides with tray, back to zero if dragged off
    also update current index based off how many items are on tray
    **/
    void Start()
    {
        currentIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        isSolved();

        if (solved && !completionShown)
        {
            completionShown = true;

            if (levelUIManager != null)
            {
                levelUIManager.CompleteLevel();
            }
        }
    }

    public bool isSolved()
    {
        solved = solvedTray.checkIfCorrect(tray);
        // print(solvedTray.checkIfCorrect(tray));
        return solvedTray.checkIfCorrect(tray);
        // if (tray.items.Count == answer.Count)
        // {
        //     for (int i = 0; i < tray.items.Count; i++)
        //     {
        //         if (tray.items[i].getString() != answer[i])
        //         {
        //             solved = false;
        //             return false;
        //         } 
        //     }
        //     solved = true;
        //     return true;
        // } else
        // {
        //     solved = false;
        //     return false;
        // }
    }
}
