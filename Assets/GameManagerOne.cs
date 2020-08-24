using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerOne : MonoBehaviour
{

    public int EnemyKilled;
    public float TimeLasted;
    // Update is called once per frame
    void Start() 
    {
        EnemyKilled = 0;
        TimeLasted = 0;
    }
    void Update()
    {
        if (GameObject.Find("Soldier") == null)
        {
            SceneManager.LoadScene("GameScene");
            EnemyKilled = 0;
            TimeLasted = 0;
        }
        TimeLasted += Time.deltaTime;

    }
}
