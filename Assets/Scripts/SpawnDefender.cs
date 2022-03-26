using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDefender : MonoBehaviour
{
    [SerializeField] Defender defender;
    private void OnMouseDown()
    {
        CreateDefender(GetSquareClicked());
        
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
        Defender newDefender = Instantiate(defender, gamePos, transform.rotation);

    }
}
