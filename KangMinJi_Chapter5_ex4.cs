using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangMinJi_Chapter5_ex4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n1 = 1;
        int n2 = 2;
        int n3 = 3;

        int maxNum = 0;
        int minNum = 0;

        if (n1 > n2 && n1 > n3) {
            maxNum = n1;
        }
        else if (n2 > n1 && n2 > n3) {
            maxNum = n2;
        }
        else if (n3 > n1 && n3 > n2)
        {
            maxNum = n3;
        }

        if (n1 < n2 && n1 < n3)
        {
            minNum = n1;
        }
        else if (n2 < n1 && n2 < n3)
        {
            minNum = n2;
        }
        else if (n3 < n1 && n3 < n2)
        {
            minNum = n3;
        }

        int sumNum = n1 + n2 + n3;
        int avgNum = sumNum / 3;

        Debug.Log($"�ִ��� {maxNum}, �ּڰ��� {minNum}, �հ�� {sumNum}, ����� {avgNum}�Դϴ�.");


        // �迭 (SY)

        Debug.Log("=== �迭 ===");
        int[] a;
        a = new int[] { 1, 2, 3 };
        
        int maxArr = Mathf.Max(a);
        int minArr = Mathf.Min(a);

        int sumArr = 0;

        for (int i = 0; i<a.Length; i++)
        {
            sumArr += a[i];
        }

        int avgArr = sumArr / a.Length;

        Debug.Log($"�ִ��� {maxArr}, �ּڰ��� {minArr}, �հ�� {sumArr}, ����� {avgArr}�Դϴ�.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
