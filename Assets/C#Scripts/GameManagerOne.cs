using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManagerOne : MonoBehaviour
{

    public static int EnemyKilled ;
    public static float TimeLasted;
    
    
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

            
           
            SceneManager.LoadScene("EndScene");
            
            
            
        }


        TimeLasted = Time.timeSinceLevelLoad;



    }
}
