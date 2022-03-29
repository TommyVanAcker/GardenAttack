using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int starCost = 100;


    public void IncreaseStars(int stars)
    {
        StarDisplay starDisplay = FindObjectOfType<StarDisplay>();
        starDisplay.AddStars(stars);
    }

    public int GetStarCost() { return starCost; }
}
