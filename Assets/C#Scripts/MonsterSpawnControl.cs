using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawnControl : MonoBehaviour
{

	public Transform[] spawnPoints;
	public GameObject[] monsters;

	public GameObject NormalZombie;
	public GameObject KnightZombie;
	public GameObject HorseZombie;
	public GameObject SummonZombie;


	int randomSpawnPoint, randomMonster;
	public static bool spawnAllowed;
	public float spawnrate = 1.5f;
	public float nextSpawn;


	bool increasedSpawnRateCheckPoint1 = false;
	bool increasedSpawnRateCheckPoint2 = false;
	bool increasedSpawnRateCheckPoint3 = false;
	bool increasedSpawnRateCheckPoint4 = false;
	bool increasedSpawnRateCheckPoint5 = false;

	
	// Use this for initialization
	void Start()
	{

		spawnAllowed = true;
		nextSpawn = 0f;

	}
	void Update()

	{
		
		if (GameManagerOne.TimeLasted > nextSpawn)
		{
			SpawnAMonster();
			nextSpawn = GameManagerOne.TimeLasted + spawnrate;
		}
		if (GameManagerOne.TimeLasted >= 60.0f && !increasedSpawnRateCheckPoint1)
		{
			spawnrate -= 0.1f;
			increasedSpawnRateCheckPoint1 = true;
		}
		if (GameManagerOne.TimeLasted >= 90.0f && !increasedSpawnRateCheckPoint2)
		{
			spawnrate -= 0.1f;
			increasedSpawnRateCheckPoint2 = true;
		}
		if (GameManagerOne.TimeLasted >= 120.0f && !increasedSpawnRateCheckPoint3)
		{
			spawnrate -= 0.1f;
			increasedSpawnRateCheckPoint3 = true;
		}
		if (GameManagerOne.TimeLasted >= 150.0f && !increasedSpawnRateCheckPoint4)
		{
			spawnrate -= 0.1f;
			increasedSpawnRateCheckPoint4 = true;
		}
		if (GameManagerOne.TimeLasted >= 180.0f && !increasedSpawnRateCheckPoint5)
		{
			spawnrate -= 0.1f;
			increasedSpawnRateCheckPoint5 = true;
		}
	}

	void SpawnAMonster()
	{

		if (GameManagerOne.TimeLasted < 20.0f)

		{
			monsters = new GameObject[1] { NormalZombie };
			spawnrate = 1.5f;
			
		}
		if (GameManagerOne.TimeLasted >= 20.0f)
		{

			monsters = new GameObject[2] { NormalZombie, KnightZombie };
		}

		if (GameManagerOne.TimeLasted >= 40.0f)
		{

			monsters = new GameObject[3] { NormalZombie, KnightZombie, HorseZombie };
		}

		if (GameManagerOne.TimeLasted >= 60.0f)
		{

			monsters = new GameObject[4] { NormalZombie, KnightZombie, HorseZombie, SummonZombie };
		}


		if (spawnAllowed)
		{
			randomSpawnPoint = Random.Range(0, spawnPoints.Length);
			randomMonster = Random.Range(0, monsters.Length);
			Instantiate(monsters[randomMonster], spawnPoints[randomSpawnPoint].position,
				Quaternion.identity);
		}

		




	}


}