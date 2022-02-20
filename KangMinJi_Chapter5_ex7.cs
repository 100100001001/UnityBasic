using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangMinJi_Chapter5_ex7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "7";
        int input = int.Parse(userInput);
        int date = 0;

        switch (input)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                date = 31;
                break;
            case 2:
                date = 28;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                date = 30;
                break;
        }

        Debug.Log($"{input}월은 {date}일까지 있습니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
