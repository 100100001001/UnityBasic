using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KangMinJi_Chapter5_ex10 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int n = 5;

        for (int i=1; i<= n; i++)
        {
            string star = "";
            for (int j = 1; j <= i; j++)
            {
                star += "¡Ú";
            }
            for (int k = 1; k <= n-i; k++)
            {
                star += "¡Ù";
            }
            Debug.Log(star);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
