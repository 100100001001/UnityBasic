using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter5 : MonoBehaviour
{
    enum CharacterState { IDLE, WALK, ATTACK, JUMP, DIE }

    // Start is called before the first frame update
    void Start()
    {
        // �б⹮(���ǹ�)

        //string userInput = "10";

        //int number = int.Parse(userInput);
        //if (number < 0)
        //{
        //    Debug.Log("����");
        //}
        //else if (number > 0)
        //{
        //    Debug.Log("���");
        //}
        //else
        //{
        //    Debug.Log("0");
        //}

        //if (number % 2 == 0)
        //{
        //    Debug.Log("¦��");
        //}
        //else
        //{
        //    Debug.Log("Ȧ��");
        //}

        //string result = number % 2 == 0 ? "¦��" : "Ȧ��";
        //Debug.Log("���� " + result);

        //Debug.Log(number % 2 == 0 ? "¦��" : "Ȧ��");


        // �б⹮(���ǹ�2)

        //string userInput = "10";

        //int number = int.Parse(userInput);
        //if (number > 0)
        //{
        //    if (number % 2 == 0)
        //    {
        //        Debug.Log("0���� ū ¦��.");
        //    }
        //    else
        //    {
        //        Debug.Log("0���� ū Ȧ��.");

        //    }
        //}
        //else
        //{
        //    Debug.Log("0���� �۰ų� ���� ��.");
        //}


        //Debug.Log("========== ���� ������ ==========");
        //if (number > 0)
        //{
        //    Debug.Log(number % 2 == 0 ? "0���� ū ¦��." : "0���� ū Ȧ��.");
        //}
        //else
        //{
        //    Debug.Log("0���� �۰ų� ���� ��.");
        //}


        // �б⹮(���ǹ�3)_switch��

        string day = "��";

        switch (day)
        {
            case "��":
                Debug.Log("Sunday");
                break;
            case "��":
                Debug.Log("Monday");
                break;
            case "ȭ":
                Debug.Log("Tuesday");
                break;
            case "��":
                Debug.Log("Wednesday");
                break;
            case "��":
                Debug.Log("Thursday");
                break;
            case "��":
                Debug.Log("Friday");
                break;
            case "��":
                Debug.Log("Saturday");
                break;
            default:
                Debug.Log("${day}��(��) ������ �ƴմϴ�.");
                break;
        }

        //
        CharacterState player = CharacterState.WALK;

        switch (player)
        {
            case CharacterState.IDLE:
                Debug.Log("�÷��̾�� �������Դϴ�.");
                break;
            case CharacterState.WALK:
                Debug.Log("�÷��̾�� �ȴ� ���Դϴ�.");
                break;
            case CharacterState.ATTACK:
                Debug.Log("�÷��̾�� ���� ���Դϴ�.");
                break;
            case CharacterState.JUMP:
                Debug.Log("�÷��̾�� ���� ���Դϴ�.");
                break;
            case CharacterState.DIE:
                Debug.Log("�÷��̾ �׾����ϴ�.");
                break;
        }


        // �ݺ���_while

        //int i = 10;

        //while (i > 0)
        //{
        //    Debug.Log($"i : {i--}");
        //}

        // �ݺ���_do while

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


        // �ݺ���_for

        //for (int i=0; i<5; i++)
        //{
        //    Debug.Log(i);
        //}


        // ��ø for��

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


        // ������_break

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


        // ������_continue

        for (int i=0; i<10; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Debug.Log($"{i} : Ȧ��");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
