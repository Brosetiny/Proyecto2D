using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FantasmaScript : MonoBehaviour
{

    Vector3 posInicial;

    GameObject rogue;

    public float velocidadfantasma = 10f;

    AudioSource _audioSource;

    void Start()
    {

        posInicial = transform.position;
        rogue = GameObject.FindGameObjectWithTag("Player");
        _audioSource = this.GetComponent<AudioSource>();

    }


    void Update()
    {

        float distancia = Vector3.Distance(transform.position, rogue.transform.position);
        float velocidadFinal = velocidadfantasma + Time.deltaTime;

        if (distancia <= 3f)
        {

            transform.position = Vector3.MoveTowards(transform.position, rogue.transform.position, velocidadFinal);
            
            if(_audioSource.isPlaying == false){
                _audioSource.Play();
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, posInicial, velocidadFinal);

            if((transform.position == posInicial) && _audioSource.isPlaying == true){
                _audioSource.Stop();
            }
        }

        //Debug.DrawLine(transform.position, rogue.transform.position, Color.black, 5f );
    }
}
