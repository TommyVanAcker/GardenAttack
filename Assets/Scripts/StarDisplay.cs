using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    TextMeshProUGUI starText;
    private void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        starText.text = stars.ToString();
    }

    public bool SpendStars(int starCost)
    {
        if(stars >= starCost)
        {
            stars -= starCost;
            UpdateDisplay();
            return true;
        }
        return false;
        
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateDisplay();
    }
}
