using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class MoverJugador : MonoBehaviour
{
    public float velocidad = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");
        float sal = Input.GetAxis("Jump");

        Vector3 movimiento = new Vector3(mh, sal, mv);

        transform.Translate(movimiento * velocidad * Time.deltaTime);


    }
}
