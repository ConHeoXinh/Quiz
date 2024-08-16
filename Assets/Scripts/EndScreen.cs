using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalscoreText;
    Score score;

    void Awake()
    {
        score = FindObjectOfType<Score>();
    }

    public void ShowFinalScore()
    {
        finalscoreText.text = "Congratulation!\nYour Score  " + score.CalculateScore() + "%";
    }
}
