using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] List<Attacker> attackers = new List<Attacker>();
    [Range(0.5f,10f)][SerializeField] float minSpawnDelay = 1f;
    [Range(10f,20f)][SerializeField] float maxSpawnDelay = 5f;
    
    bool spawn = true;
    
    

    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }

    }

    void SpawnAttacker()
    {
        Attacker attacker =  GameObject.Instantiate(attackers[Random.Range(0, attackers.Count)], transform.position, Quaternion.identity, transform);
        
    }

  
   
    public bool IsAttackerInMyLane()
    {
        if (transform.childCount > 0)
        {
            return true;
        }
        else { return false; }



    }
}
