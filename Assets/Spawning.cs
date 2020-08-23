using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject NormalZombie;
    public float spawnRate = 2f;
    float nextSpawn = 0f;
    

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn) {
            
            Instantiate(NormalZombie, transform.position, Quaternion.identity);
            nextSpawn = Time.time + spawnRate;

        }
        
    }
}
