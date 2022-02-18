using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangMinJi_Chapter5_ex5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userGrade = "4";
        string userScore = "80";

        int grade = int.Parse(userGrade);
        int score = int.Parse(userScore);

        string result = "";

        if (grade == 4)
        {
            if (score >= 70) {
                result = "합격";
            }
        }
        else if (grade < 4 && grade > 0)
        {
            if (score >= 60)
            {
                result = "합격";
            }
        }
        else
        {
            result = "다시";
        }

        if (result == "합격")
        {
            Debug.Log("축하드립니다. 합격입니다.");
        }
        else if (result == "다시")
        {
            Debug.Log("1학년 ~ 4학년만 확인이 가능합니다.");
        }
        else
        {
            Debug.Log("불합격입니다. ㅠ.ㅠ");
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
