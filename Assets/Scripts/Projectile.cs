using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float projectiledegree = 20f;
    [SerializeField] float damagePts = 5f;
   

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed, Space.World);
        //transform.RotateAround(transform.position, Vector3.back, projectiledegree * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var attacker = collision.GetComponent<Attacker>();
        var health = collision.GetComponent<Health>();

        if(attacker && health)
        {
            health.DealDamage(damagePts);
            Destroy(gameObject);           
        }
        
    }

}
