using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI bestScoreText;
    public void Start()
    {
        string playerName = PlayerPrefs.GetString("BestScorePlayerName", "Player");

        int bestScore = PlayerPrefs.GetInt("BestScore", 0);

        bestScoreText.text = "Best Score : " + playerName + " : " + bestScore;

    }
}
