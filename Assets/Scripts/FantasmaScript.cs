using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{

    Vector3 posInicial;

    GameObject rogue;

    public float velocidadfantasma = 10f;
    void Start()
    {

        posInicial = transform.position;
        rogue = GameObject.FindGameObjectWithTag("Player");

    }


    void Update()
    {

        float distancia = Vector3.Distance(transform.position, rogue.transform.position);
        float velocidadFinal = velocidadfantasma + Time.deltaTime;

        if (distancia <= 3f)
        {

            transform.position = Vector3.MoveTowards(transform.position, rogue.transform.position, velocidadFinal);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, posInicial, velocidadFinal);
        }

        //Debug.DrawLine(transform.position, rogue.transform.position, Color.black, 5f );
    }
}
