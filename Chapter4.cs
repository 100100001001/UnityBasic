using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ��� ������

        //int a = 111 + 222;
        //Debug.Log($"a : {a}");

        //int b = a - 100;
        //Debug.Log("b : " + b);

        //int c = b * 10;
        //Debug.Log($"c : {c}");

        //float d = c / 6.3f;
        //Debug.Log("d : " + d);

        //Debug.Log($"22 / 7 = {22 / 7}({22 % 7})");


        // ���� �����ڿ� ���� ������

        //int a = 10;
        //Debug.Log(a++);
        //Debug.Log(++a);

        //Debug.Log(a--);
        //Debug.Log(--a);


        // ���� ������

        //Debug.Log($"3 > 4 : {3 > 4}");
        //Debug.Log($"3 >= 4 : {3 >= 4}");
        //Debug.Log($"3 < 4 : {3 < 4}");
        //Debug.Log($"3 <= 4 : {3 <= 4}");
        //Debug.Log($"3 == 4 : {3 == 4}");
        //Debug.Log($"3 != 4 : {3 != 4}");


        // ���� ������

        //Debug.Log("Testing && ...");
        //Debug.Log($" 1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}"); // t
        //Debug.Log($" 1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}"); // f
        //Debug.Log($" 1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}"); // f
        //Debug.Log($" 1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}"); // f

        //Debug.Log("Testing || ...");
        //Debug.Log($" 1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}"); // t
        //Debug.Log($" 1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}"); // t
        //Debug.Log($" 1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}"); // f
        //Debug.Log($" 1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}"); // t

        //Debug.Log("Testing ! ...");
        //Debug.Log($"!True : {!true}"); // f
        //Debug.Log($"!False : {!false}"); // t


        // ���� ������

        //string result = (10 % 2) == 0 ? "¦��" : "Ȧ��";
        //Debug.Log(result);


        // �Ҵ� ������

        int a;
        a = 100;
        Debug.Log($"a = 100 : {a}"); // 100
        a += 90;
        Debug.Log($"a += 90 : {a}"); // 190
        a -= 80;
        Debug.Log($"a -= 80 : {a}"); // 110
        a *= 70;
        Debug.Log($"a *= 70 : {a}"); // 7700
        a /= 60;
        Debug.Log($"a /= 60 : {a}"); // 128
        a %= 50;
        Debug.Log($"a %= 50 : {a}"); // 28
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}