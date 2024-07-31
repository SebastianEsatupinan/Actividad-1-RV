using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesaparecerPuerta : MonoBehaviour
{
    public GameObject puerta; // Puerta que desaparecerá

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (puerta != null)
            {
                puerta.SetActive(false); // Desaparece la puerta
            }
        }
    }
}
