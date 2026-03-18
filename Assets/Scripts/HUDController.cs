using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public static HUDController instance;

    private void Awake()
    {
        instance = this;
    }
    // Update is called once per frame
   public void UpdateScoreText(int score)
    {
        scoreText.text = $"Score: {score:0000}";
    }
}
