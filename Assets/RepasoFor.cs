using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepasoFor : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        //escribir en consola los números enteros desde cero a 4
        for (int i = 0; i<5; i++)
        {
            Debug.Log(i);
        }

        //escribir en consola los números enteros entre 10 y 40 inclusive
        for (int i = 10; i <= 40; i++)
        {
            Debug.Log(i);
        }

        //escribir en consola los números enteros entre dos nros ingresados por Inspector
        for (int i = num1; i <num2; i++)
        {
            Debug.Log(i);
        }

        //escribir en consola los números enteros desde 11 hasta 1 excepto el 3
        for (int i = 11; i >0; i--)
        { 
            if( i == 3)
            {
                continue;
            }
            Debug.Log(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
