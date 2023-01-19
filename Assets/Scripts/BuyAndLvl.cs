using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class BuyAndLvl : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private List<TextMeshProUGUI> _list;
    void Start()
    {
        int count = 3;
        foreach (var item in _list)
        {
            count++;
            item.text += Fibonacci(147, count);
        }
    }

    public double st(int c)
    {
        return Fibonacci(144, c);
    }
    public static double Fibonacci(int n,int c)
    {
        double[] fib = new double[n];
        fib[0] = 0;
        fib[1] = 1;
        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        for (int i = 0; i < n; i++)
        {
            if (i>40)
            {
                string valueString = fib[i].ToString("E3");
                int eIndex = valueString.IndexOf("E");
                valueString = valueString.Insert(eIndex-3, "");
               // Console.Write($"{valueString} ");
               if(i==c)
               {
                   return Convert.ToDouble(valueString);
               }
               
            }
            else
            {
                if(i==c)
                {
                    return fib[i];
                }
                //Console.Write($"{fib[i]} ");
            }
       
        }

        return 1;
    }
    
}
