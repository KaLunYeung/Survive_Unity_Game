using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Pathfinding
{
    public class Summon : MonoBehaviour
    {
        public GameObject NormalZombie;
        public float spawnRate = 2f;
        float nextSpawn = 0f;



        void Update()
        {
            if (this.GetComponent<AIPath>().maxSpeed == 0)
            {
                if (Time.time > nextSpawn)
                {

                    Instantiate(NormalZombie, transform.position, Quaternion.identity);
                    nextSpawn = Time.time + spawnRate;

                }

            }
        }
    }
}