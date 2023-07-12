using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    
    private int score;
    public Text scoreInterface;
    public GameObject panelEnd; 
    // Update is called once per frame
    void Update()
    {
        scoreInterface.text = "Убито врагов: " + score.ToString()+"/4";
        if (score == 4)
        {
            panelEnd.SetActive(true);
        }
    }
    public void CounterKillEnemy()
    {
        score++;
    }

}
