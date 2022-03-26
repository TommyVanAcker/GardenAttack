using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] List<Attacker> attacker = new List<Attacker>();
    [Range(0.5f,3f)][SerializeField] float minSpawnDelay = 1f;
    [Range(1f,5f)][SerializeField] float maxSpawnDelay = 5f;
    
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
        GameObject.Instantiate(attacker[Random.Range(0, attacker.Count)], transform.position, Quaternion.identity, transform);
    }

   
}
