using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangMinJi_Chapter5_ex8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string userInput = "7";
        int input = int.Parse(userInput);
        string season = "";

        switch (input) {
            case 3:
            case 4:
            case 5:
                season = "봄";
                break;
            case 6:
            case 7:
            case 8:
                season = "여름";
                break;
            case 9:
            case 10:
            case 11:
                season = "가을";
                break;
            case 12:
            case 1:
            case 2:
                season = "겨울";
                break;
        }

        Debug.Log($"{input}월은 {season}입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
