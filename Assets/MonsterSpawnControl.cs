using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnControl : MonoBehaviour
{

	public Transform[] spawnPoints;
	public GameObject[] monsters;

	public GameObject KnightZombie;
	public GameObject HorseZombie;
	public GameObject SummonZombie;


	int randomSpawnPoint, randomMonster;
	public static bool spawnAllowed;
	float spawnrate = 1.5f;
	
	private float nextSpawn = 0f;


	bool increasedSpawnRateCheckPoint1 = false;
	bool increasedSpawnRateCheckPoint2 = false;
	bool increasedSpawnRateCheckPoint3 = false;
	bool increasedSpawnRateCheckPoint4 = false;
	bool increasedSpawnRateCheckPoint5 = false;

	// Use this for initialization
	void Start()
	{

		spawnAllowed = true;

	}
	void Update()

	{
		if (Time.time > nextSpawn)
		{
			SpawnAMonster();
			nextSpawn = Time.time + spawnrate;
		}
		if (Time.time >= 60.0f && !increasedSpawnRateCheckPoint1)
		{
			spawnrate -= 0.1f;
			increasedSpawnRateCheckPoint1 = true;
		}
		if (Time.time >= 120.0f && !increasedSpawnRateCheckPoint2)
		{
			spawnrate -= 0.1f;
			increasedSpawnRateCheckPoint2 = true;
		}
		if (Time.time >= 180.0f && !increasedSpawnRateCheckPoint3)
		{
			spawnrate -= 0.1f;
			increasedSpawnRateCheckPoint3 = true;
		}
		if (Time.time >= 210.0f && !increasedSpawnRateCheckPoint4)
		{
			spawnrate -= 0.1f;
			increasedSpawnRateCheckPoint4 = true;
		}
		if (Time.time >= 240.0f && !increasedSpawnRateCheckPoint5)
		{
			spawnrate -= 0.1f;
			increasedSpawnRateCheckPoint5 = true;
		}
	}

	void SpawnAMonster()
	{
		
		if (spawnAllowed)
		{
			randomSpawnPoint = Random.Range(0, spawnPoints.Length);
			randomMonster = Random.Range(0, monsters.Length);
			Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position,
				Quaternion.identity);
		}

		if (Time.time >= 20.0f)
		{
			
			monsters = new GameObject[2] { monsters[0], KnightZombie };
		}

		if (Time.time >= 40.0f)
		{
			
			monsters = new GameObject[3] { monsters[0], KnightZombie, HorseZombie };
		}

		if (Time.time >= 60.0f)
		{
			
			monsters = new GameObject[4] { monsters[0], KnightZombie , HorseZombie , SummonZombie};
		}




	}


}