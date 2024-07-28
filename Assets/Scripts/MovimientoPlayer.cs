using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    public float MovementSpeed = 5.0f;
    //private Animator anim;
    private float x, y;

    void Start()
    {
        //anim = GetComponent<Animator>();
    }

    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        //anim.SetFloat("VelX", x);
        //anim.SetFloat("VelY", y);

        Vector3 movement = new Vector3(x, 0, y) * MovementSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}
