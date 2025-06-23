using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject[] carteles;
    public int RandomElement;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(ActivateRandomElement),0, 2f);
    }

    void DeactivateAll()
    {

        RandomElement = Random.Range(0, carteles.Length);
        for (int i = 0; i<carteles.Length; i++)
        {
            carteles[i].SetActive(false);
        }
    }

    void ActivateRandomElement()
    {
        DeactivateAll();
        carteles[RandomElement].SetActive(true);
    }
}
