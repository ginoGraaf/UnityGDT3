using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    [SerializeField]
    Text ScoreText;
    int score = 0;
    // Update is called once per frame
    public static UIScore Instance;
    private void Awake()
    {
        Instance = this;
    }
    void Update()
    {
        ScoreText.text = "Score " + score;
    }


   public void AddScore(int amount)
    {
        score += amount;
    }
}
