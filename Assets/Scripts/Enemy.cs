using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float heath = 10;
    public int damage = 1;

    public void Die()
    {
        if (heath == 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamge(int damge) // 10 = 10 - 5 = 5 +=
    {
        heath -= damge;
        Die();
    }
    public void OnTriggerEnter2D(Collider2D other)
    {

        {
            if (other.gameObject.CompareTag("Player"))
            {
                HpPlayer hp = other.GetComponent<HpPlayer>();
                // goi 
                hp.takeDamage(damage); // Enemy. takedame();

            }
        }

    }
}
