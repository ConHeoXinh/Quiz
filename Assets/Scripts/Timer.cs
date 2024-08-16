using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float timerValue;
    [SerializeField] float timeToCompleteQuestion = 5f;
    [SerializeField] float timeShowCorrectQuestion = 2f;

    public bool loadNextQuestion ;
    public bool isAnsweringQuestion ;
    public float fillFraction;
    public bool hasAnsweringQuestion;

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if (isAnsweringQuestion)
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeShowCorrectQuestion;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeShowCorrectQuestion;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }


    }



}
