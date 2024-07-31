using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerPuerta : MonoBehaviour
{
    public GameObject puerta; // Puerta que aparecerá

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (puerta != null)
            {
                puerta.SetActive(true); // Aparece la puerta
            }
        }
    }
}
