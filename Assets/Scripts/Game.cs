using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public int Score { get; set; } = 0;
    public TextMeshProUGUI scoreUI;
    public TextMeshProUGUI timerUI;

    static Game instance = null;

    float timer = 90.0f;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        timerUI.text = string.Format("{0:D2}", (int)timer);
    }

    public static Game Instance
    {
        get
        {
            return instance;
        }
    }

    public void AddPoints(int points)
    {
        Score += points;
        scoreUI.text = string.Format("{0:D4}", Score);
        
        //Debug.Log(Score);
    }
}
