using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboUIManager : MonoBehaviour
{
    public Text comboText;
    private List<string> currentCombo = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        UpdateComboText();
    }

    public void AddIngredient(string ingredientName)
    {
        currentCombo.Add(ingredientName);
        UpdateComboText();
    }

    public void ClearCombo()
    {
        currentCombo.Clear();
        UpdateComboText();
    }

    private void UpdateComboText()
    {
        if (currentCombo.Count == 0)
        {
            comboText.text = "Current Combo:";
            return;
        }

        comboText.text = "Current Combo: " + string.Join(", ", currentCombo);
    }
}
