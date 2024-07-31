using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public float MovementSpeed = 5.0f;
    private float x, y;

    void Start()
    {
        // Aquí podrías inicializar cualquier otra cosa que necesites.
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        // Restringe el movimiento a solo una dirección a la vez
        if (Mathf.Abs(x) > Mathf.Abs(y))
        {
            y = 0; // Anula el movimiento vertical si el movimiento horizontal es mayor
        }
        else
        {
            x = 0; // Anula el movimiento horizontal si el movimiento vertical es mayor
        }

        Vector3 movement = new Vector3(x, 0, y) * MovementSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}
