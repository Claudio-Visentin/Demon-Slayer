using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour {
    public BoxCollider trigger;
    public List <GameObject> zombies = new List<GameObject> ();
    public bool animationtrigger;


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag ("Enemy"))
        {
            zombies.Add (col.gameObject);
            foreach  (GameObject zombie in zombies)
            {
                zombie.GetComponent <ZombieAI>().isinRange = true;
            }
            for (int i = 0; i < zombies.Count; i++)
            {
                if (zombies[i] == null)
                {
                    zombies.Remove(zombies[i]);
                }
            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            zombies.Remove(col.gameObject);
            foreach (GameObject zombie in zombies)
            {
                zombie.GetComponent<ZombieAI>().isinRange = false;
            }
        }
    }
    void isAttacking()
    {
        for (int i = 0; i < zombies.Count; i++)
        {
            if (zombies [i] == null)
            {
                zombies.Remove(zombies[i]);
            }
        }
        foreach (GameObject zombie in zombies)
        {
            animationtrigger = true;
            zombie.GetComponent<ZombieAI>().health -= 1;
            zombies.Remove(zombie);
            
        } 
        
    }
}
