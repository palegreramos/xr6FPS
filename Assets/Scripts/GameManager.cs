using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;
    public static GameManager instance;
    public HUDController HUD;
 
    private void Awake()
    {
        instance = this;
    }

   
   public void UpdateScore(int points)
    {
        score += points;
        HUD.UpdateScoreText(score);

    }
}
