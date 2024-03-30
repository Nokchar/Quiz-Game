using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2, 6)]
    [SerializeField] string question = "Enter new question";

    public string GetQuestion()
    {
        return question;
    }

}


// public class Test
// {
//     QuestionSO questionSO;
//     void TestA()
//     {
//         string questionText = questionSO.GetQuestion();
//     }
// }