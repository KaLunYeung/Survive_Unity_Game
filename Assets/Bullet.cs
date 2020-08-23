using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {


            Destroy(this.gameObject);


            collision.gameObject.GetComponent<HealthSystem>().TakeDamage(1);
            if (collision.gameObject.GetComponent<HealthSystem>().currentHealth <= 0)
            {
                Destroy(collision.gameObject);
            }

        }
        
    }
}
