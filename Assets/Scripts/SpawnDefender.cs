using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefender : MonoBehaviour
{
    Defender defender;
    private void OnMouseDown()
    {
        CreateDefender(GetSquareClicked());
        
    }
    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }


    Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 gamePos =  Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 roundedGamePos =  new Vector2(Mathf.Round(gamePos.x),Mathf.Round(gamePos.y));
        return roundedGamePos;
    }

    void CreateDefender(Vector2 gamePos)
    {
        if (!defender) { return; }
        int starCost = defender.GetStarCost();
        if (FindObjectOfType<StarDisplay>().SpendStars(starCost))
        {
            Defender newDefender = Instantiate(defender, gamePos, transform.rotation);
        }
        

    }
}
