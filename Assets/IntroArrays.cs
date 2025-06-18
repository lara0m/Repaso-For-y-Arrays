using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroArrays : MonoBehaviour
{
    public int[] edades;
    // Start is called before the first frame update
    void Start()
    {
        //escribir el primer elemento del array
        Debug.Log(edades[0]);

        //escribir el ultimo elemento del array
        Debug.Log(edades[edades.Length - 1]);

        //escribir todos los elementos del array
        for(int i = 0; i<edades.Length; i++)
        {
            Debug.Log(edades[i]);
        }
        foreach (var edad in edades)
        {
            Debug.Log(edad);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
