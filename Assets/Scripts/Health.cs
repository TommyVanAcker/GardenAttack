using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float healtPts = 30f;
    // Start is called before the first frame update
   

    public void DealDamage(float damagePts)
    {
        healtPts -= damagePts;
        if(healtPts <= 0)
        {
            Destroy(gameObject);
        }
    }
}
