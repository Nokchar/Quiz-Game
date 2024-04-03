using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;

    void Awake()
    {
        scoreKeeper = FindAnyObjectByType<ScoreKeeper>();
    }


    public void ShowFinalScore()
    {
        finalScoreText.text = "축하합니다!\n 점수는" + scoreKeeper.CalculateScore() + "입니다.";
    }


}
