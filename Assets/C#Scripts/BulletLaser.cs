using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLaser : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {


            Destroy(this.gameObject, 0.5f);


            collision.gameObject.GetComponent<HealthSystem>().TakeDamage(5);
            if (collision.gameObject.GetComponent<HealthSystem>().currentHealth <= 0)
            {
                Destroy(collision.gameObject);
                GameManagerOne.EnemyKilled += 1;
            }

        }

    }
}
