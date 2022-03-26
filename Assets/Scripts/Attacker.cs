using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Health))]
public class Attacker : MonoBehaviour
{
    float currentSpeed = 3f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.left * Time.deltaTime * currentSpeed);
    }

    
    public void SetMovementSpeed(float speed)
    {
        currentSpeed = speed;
    }
}
