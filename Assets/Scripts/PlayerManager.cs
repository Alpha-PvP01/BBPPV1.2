using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class PlayerManager : MonoBehaviour
{
    public RectTransform plaerHelthBar;
    public static int playerHelth;
    public static bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerHelth = 100;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
