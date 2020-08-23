using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            
            Destroy(this.gameObject);



            
            Destroy(collision.gameObject);
            

        }

        else if (collision.gameObject.tag == "Player")
        {
            




            Destroy(collision.gameObject);
        }

    }
}
