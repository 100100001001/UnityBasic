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
                result = "�հ�";
            }
        }
        else if (grade < 4 && grade > 0)
        {
            if (score >= 60)
            {
                result = "�հ�";
            }
        }
        else
        {
            result = "�ٽ�";
        }

        if (result == "�հ�")
        {
            Debug.Log("���ϵ帳�ϴ�. �հ��Դϴ�.");
        }
        else if (result == "�ٽ�")
        {
            Debug.Log("1�г� ~ 4�г⸸ Ȯ���� �����մϴ�.");
        }
        else
        {
            Debug.Log("���հ��Դϴ�. ��.��");
        }


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
