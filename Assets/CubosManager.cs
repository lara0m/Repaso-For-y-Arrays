using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubosManager : MonoBehaviour
{
    public CuboScript[] cubos;
    // Start is called before the first frame update
    void Start()
    {
        cubos = FindObjectsOfType<CuboScript>();
        //for (int i = 0; i < cubos.Length; i++)
        //{
        //    if (!cubos[i].isPersistent)
        //    {
        //        Destroy(cubos[i].gameObject);
        //    }
        //}

        //posicionar todos los cubos en el cero del espacio
        //for (int i = 0; i< cubos.Length; i++)
        //{
        //    cubos[i].transform.position = new Vector3(0, 0, 0);
        //}

        //posicionar los cubos en "escalera"
        for (int i = 0; i < cubos.Length; i++)
        {
            cubos[i].transform.position = new Vector3(i, i, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
