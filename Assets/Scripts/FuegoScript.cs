using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FuegoScript : MonoBehaviour
{

    GameObject rogue;

    bool bolaDcha = true;
    bool bolaIzq = false;
    bool bolaArribaDcha = false;
    bool bolaArribaIzq = false;
    bool bolaAbajoDcha = false;
    bool bolaAbajoIzq = false;

    public float speedBala = 0.05f;

    float tiempoDes = 3f;

    float tiempopasado;

    // Start is called before the first frame update
    void Start()
    {
       rogue = GameObject.Find("Rogue");
       bolaDcha = rogue.GetComponent<Movement>().mirandoDcha;
       bolaIzq = rogue.GetComponent<Movement>().mirandoIzq;
       bolaArribaDcha = rogue.GetComponent<Movement>().mirandoArribaDcha;
       bolaAbajoDcha = rogue.GetComponent<Movement>().mirandoAbajoDcha;
       bolaArribaIzq = rogue.GetComponent<Movement>().mirandoArribaIzq;
       bolaAbajoIzq = rogue.GetComponent<Movement>().mirandoAbajoIzq;
       tiempopasado = Time.time;
    }

    // Update is called once per frame
    void Update()
    {

        if(bolaDcha){
            transform.Translate(speedBala*Time.deltaTime,0,0, Space.World);
        }
        if(bolaIzq){
            transform.Translate(speedBala*Time.deltaTime*-1,0,0, Space.World);
        }
        if(bolaAbajoIzq){
            transform.Translate(speedBala*Time.deltaTime*-1,speedBala*Time.deltaTime*-1,0, Space.World);
        }
        if(bolaArribaIzq){
            transform.Translate(speedBala*Time.deltaTime*-1,speedBala*Time.deltaTime,0, Space.World);
        }
        if(bolaAbajoDcha){
            transform.Translate(speedBala*Time.deltaTime,speedBala*Time.deltaTime*-1,0, Space.World);
        }
        if(bolaArribaDcha){
            transform.Translate(speedBala*Time.deltaTime,speedBala*Time.deltaTime,0, Space.World);
        }

        
        if(Time.time >= tiempopasado + tiempoDes){
            Destroy(this.gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log(col.gameObject.name.StartsWith("Fantasma"));

        if(col.gameObject.tag == "Enemigo"){
            Destroy(col.gameObject);

            GameManager.contadorfantasmas += 1;

            Destroy(this.gameObject);

        }
        
       /* if(col.gameObject.name.StartsWith("Fantasma")){

            Destroy(col.gameObject);

        }*/

    }

}
