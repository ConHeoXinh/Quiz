using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Quiz Question", fileName ="New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 4)]
    [SerializeField] string question = "Enter new question here?";
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerindex;

    public string GetQuestion()
    {
        return question;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerindex;
    }

    public string GetAnswer(int index)
    {
            return answers[index];
    }
}

