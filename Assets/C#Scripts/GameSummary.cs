using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSummary : MonoBehaviour
{
    
    void Start()
    {


        Text myText = GameObject.Find("/Canvas/GameSummary").GetComponent<Text>();

        myText.text = "YOU ELIMINATED " + GameManagerOne.EnemyKilled + " ZOMBIES & SURVIVED " + (int) (GameManagerOne.TimeLasted) + " SECONDS";
                         
                        

        

        

        GameManagerOne.EnemyKilled = 0;
        GameManagerOne.TimeLasted = 0;

        
    }
}
