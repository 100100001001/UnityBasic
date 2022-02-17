using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter3 : MonoBehaviour
{
    enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

    enum Hehe { Qkqka, Qka }
    //enum DialogResult { HEHE, HIHIHI }
    //enum DialogResult { YES, NO, CONFIRM, OK, CANCEL }

    // Start is called before the first frame update    
    void Start()
    {
        // 정수
        //int a = -10;
        //int b = 40;

        //Debug.Log("a = " + a + ", b = " + b);
        //Debug.Log($"a = {a}, b = {b}");


        // 부동소수점
        //float a = 3.14159265358979323846f;
        //double b = 3.14159265358979323846;

        //Debug.Log("a = " + a + ", b = " + b);
        //Debug.Log($"a = {a}, b = {b}");


        // 문자
        //char a = '안'; char b = '녕';
        //char c = '하'; char d = '세';
        //char e = '요';

        //Debug.Log(a.ToString() + b + c + d + e); // 선유
        //Debug.Log("" + a + b + c + d + e);
        //Debug.Log($"{a}{b}{c}{d}{e}");


        // 문자열
        //string a = "안녕하세요?";
        //string b = "너무 춥습니다.";

        //Debug.Log(a);
        //Debug.Log(b);


        // 논리
        //bool a = true;
        //bool b = false;

        //Debug.Log(a);
        //Debug.Log(b);


        // 데이터 형식 바꾸기
        //float a = 0.9f;
        //int b = (int)a;
        //Debug.Log(b);

        //float c = 1.1f;
        //int d = (int)c;
        //Debug.Log(d);


        // 문자열을 숫자로, 숫자를 문자열로
        //int a = 123;
        //string b = a.ToString();
        //Debug.Log(b);

        //float c = 3.14f;
        //string d = c.ToString();
        //Debug.Log(d);

        //string e = "123456";
        //int f = int.Parse(e);
        //Debug.Log(f);

        //string g = "1.2345";
        //float h = float.Parse(g);
        //Debug.Log(h);

        //string j = "3";
        //float k = float.Parse(j);
        //Debug.Log(k);

        //int aaa = 1;
        //float bbb = (float)aaa;
        //Debug.Log(bbb);


        // 상수
        //const int MAX_INT = 2147483647;
        //const int MIN_INT = -2147483648;

        //Debug.Log(MAX_INT);
        //Debug.Log(MIN_INT);


        // 열거
        Debug.Log((int)DialogResult.YES);
        Debug.Log((int)DialogResult.NO);
        Debug.Log((int)DialogResult.CANCEL);
        Debug.Log((int)DialogResult.CONFIRM);
        Debug.Log((int)DialogResult.OK);

        //Debug.Log((int)DialogResult.HEHE);
        //Debug.Log((int)DialogResult.HIHIHI);

        Debug.Log((int)Hehe.Qka);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
