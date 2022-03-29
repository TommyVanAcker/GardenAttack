using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] Transform gun;

    AttackerSpawner[] spawners;
    Animator animFire;
    bool canFire = false;

    Transform projectileParent;



    private void Start()
    {
        spawners = FindObjectsOfType<AttackerSpawner>();
        animFire = GetComponent<Animator>();
        projectileParent = GameObject.FindGameObjectWithTag("Projectile").transform;
        
    }
    private void Update()
    {
        CheckIfAllowedToFire();
    }

    private void CheckIfAllowedToFire()
    {
        if (IsAttackerInMyLane())
        {
            AnimCanFire(true);

        }
        else
        {
            AnimCanFire(false);

        }
    }

    void AnimCanFire(bool fire)
    {
        canFire = fire;
        animFire.SetBool("isAttacking", fire);
    }

    bool IsAttackerInMyLane()
    {
        foreach (AttackerSpawner attackerspawner in spawners)
        {
            bool inLaneOfDefender = (Mathf.Abs(attackerspawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            
            if (inLaneOfDefender && attackerspawner.IsAttackerInMyLane())
            {
                return true;
            }
        }
        return false;
    }
    public void Fire()
    {
        if (canFire)
        {
            GameObject.Instantiate<GameObject>(projectile, gun.position, Quaternion.identity, projectileParent);
        }
        
    }
}
