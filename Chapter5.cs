using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5 : MonoBehaviour
{
    enum CharacterState { IDLE, WALK, ATTACK, JUMP, DIE }

    // Start is called before the first frame update
    void Start()
    {
        // 분기문(조건문)

        //string userInput = "10";

        //int number = int.Parse(userInput);
        //if (number < 0)
        //{
        //    Debug.Log("음수");
        //}
        //else if (number > 0)
        //{
        //    Debug.Log("양수");
        //}
        //else
        //{
        //    Debug.Log("0");
        //}

        //if (number % 2 == 0)
        //{
        //    Debug.Log("짝수");
        //}
        //else
        //{
        //    Debug.Log("홀수");
        //}

        //string result = number % 2 == 0 ? "짝수" : "홀수";
        //Debug.Log("따란 " + result);

        //Debug.Log(number % 2 == 0 ? "짝수" : "홀수");


        // 분기문(조건문2)

        //string userInput = "10";

        //int number = int.Parse(userInput);
        //if (number > 0)
        //{
        //    if (number % 2 == 0)
        //    {
        //        Debug.Log("0보다 큰 짝수.");
        //    }
        //    else
        //    {
        //        Debug.Log("0보다 큰 홀수.");

        //    }
        //}
        //else
        //{
        //    Debug.Log("0보다 작거나 같은 수.");
        //}


        //Debug.Log("========== 조건 연산자 ==========");
        //if (number > 0)
        //{
        //    Debug.Log(number % 2 == 0 ? "0보다 큰 짝수." : "0보다 큰 홀수.");
        //}
        //else
        //{
        //    Debug.Log("0보다 작거나 같은 수.");
        //}


        // 분기문(조건문3)_switch문

        string day = "금";

        switch (day)
        {
            case "일":
                Debug.Log("Sunday");
                break;
            case "월":
                Debug.Log("Monday");
                break;
            case "화":
                Debug.Log("Tuesday");
                break;
            case "수":
                Debug.Log("Wednesday");
                break;
            case "목":
                Debug.Log("Thursday");
                break;
            case "금":
                Debug.Log("Friday");
                break;
            case "토":
                Debug.Log("Saturday");
                break;
            default:
                Debug.Log("${day}는(은) 요일이 아닙니다.");
                break;
        }

        //
        CharacterState player = CharacterState.WALK;

        switch (player)
        {
            case CharacterState.IDLE:
                Debug.Log("플레이어는 대기상태입니다.");
                break;
            case CharacterState.WALK:
                Debug.Log("플레이어는 걷는 중입니다.");
                break;
            case CharacterState.ATTACK:
                Debug.Log("플레이어는 공격 중입니다.");
                break;
            case CharacterState.JUMP:
                Debug.Log("플레이어는 점프 중입니다.");
                break;
            case CharacterState.DIE:
                Debug.Log("플레이어가 죽었습니다.");
                break;
        }


        // 반복문_while

        //int i = 10;

        //while (i > 0)
        //{
        //    Debug.Log($"i : {i--}");
        //}

        // 반복문_do while

        //int i = 3;

        //do
        //{
        //    Debug.Log($"a) i : {i--}");
        //}
        //while (i > 0);

        //do
        //{
        //    Debug.Log($"b) i : {i--}");
        //}
        //while (i > 0);

        // a) 3 2 1 b) 0 


        // 반복문_for

        //for (int i=0; i<5; i++)
        //{
        //    Debug.Log(i);
        //}


        // 중첩 for문

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Debug.Log("*");
        //    }
        //}


        // foreach

        //int student1 = 100;
        //int student2 = 80;
        //int student3 = 70;
        //int student4 = 60;
        //int student5 = 30;


        //int[] arr = new int[] { 0, 1, 2, 3, 4 };

        //foreach (int a in arr)
        //{
        //    Debug.Log(a);
        //}


        // 점프문_break

        //int i = 0;
        
        //while (i >= 0)
        //{
        //    if (i == 10)
        //    {
        //        break;
        //    }
        //    Debug.Log(i++);
        //}
        //Debug.Log("Prison Break");


        // 점프문_continue

        for (int i=0; i<10; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Debug.Log($"{i} : 홀수");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
