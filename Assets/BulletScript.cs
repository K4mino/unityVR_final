using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int damage = 50; 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            Zombie zombie = collision.gameObject.GetComponent<Zombie>();
            if (zombie != null)
            {
                zombie.TakeDamage(damage);
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zombie")) // Assumes your zombie has the "Zombie" tag
        {
            // Apply damage or other effects here. Example:
            Zombie zombieHealth = other.GetComponent<Zombie>();
            if (zombieHealth != null)
            {
                zombieHealth.TakeDamage(damage);
            }
            else
            {
                //  If the zombie doesn't have a health script, just destroy it.
                gameObject.SetActive(false);
            }

            
        }
    }
}
