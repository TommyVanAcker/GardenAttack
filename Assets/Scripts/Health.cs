using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float healtPts = 30f;
    [SerializeField] GameObject deathVfx;

    
    private void Start()
    {
        
    }

    public void DealDamage(float damagePts)
    {
        healtPts -= damagePts;
        if(healtPts <= 0)
        {
            TriggerDeathVfx();
            Destroy(gameObject);

        }
    }

    private void TriggerDeathVfx()
    {
        if (!deathVfx) { return; }
        GameObject vfx = GameObject.Instantiate<GameObject>(deathVfx, gameObject.transform.position, Quaternion.identity);
        Destroy(vfx,3f);
        
    }
}
