using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangMinJi_Chapter5_ex1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "70";
        string grade = "";

        int score = int.Parse(userInput);

        if (score >= 90) {
            grade = "A";
        }
        else if (score >= 80) {
            grade = "B";
        }
        else if (score >= 70) {
            grade = "C";
        }
        else
        {
            grade = "F";
        }

        Debug.Log($"�Է��� ���� {score}��(��) {grade} ���� �Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
