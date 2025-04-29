using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using JetBrains.Annotations;
using UnityEditor.Callbacks;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float multiplicador = 5f;

    private Rigidbody2D rb;

    private Animator animatorController;

    public bool mirandoDcha = true;
    public bool mirandoIzq = false;
    public bool mirandoArribaDcha = false;
    public bool mirandoArribaIzq = false;
    public bool mirandoAbajoDcha = false;
    public bool mirandoAbajoIzq = false;

    GameObject respawn;

    float movTeclas;

    float movTeclasVert;

    bool soyazul;

    void Start()
    {
        Debug.Log("Hola mundo");

        rb = GetComponent<Rigidbody2D>();

        animatorController = this.GetComponent<Animator>();

        respawn = GameObject.Find("Respawn");

        transform.position = respawn.transform.position;
    }

    void Update()
    {

        if(GameManager.muerto == true) return;
        
        // Movimiento
        movTeclas = Input.GetAxis("Horizontal");

        movTeclasVert = Input.GetAxis("Vertical");

        float miDeltaTime = Time.deltaTime;

        // Mirando izq
        if (movTeclas < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            mirandoDcha = false;
            mirandoArribaDcha = false;
            mirandoArribaIzq = false;
            mirandoAbajoDcha = false;
            mirandoAbajoIzq = false;
            mirandoIzq = true;
        }
        // Mirando der
        if (movTeclas > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            mirandoDcha = true;
            mirandoArribaDcha = false;
            mirandoArribaIzq = false;
            mirandoAbajoDcha = false;
            mirandoAbajoIzq = false;
            mirandoIzq = false;
        }
        //Mirando abajo izq
         if ((movTeclas < 0) && (movTeclasVert<0))
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            mirandoDcha = false;
            mirandoArribaDcha = false;
            mirandoArribaIzq = false;
            mirandoAbajoDcha = false;
            mirandoAbajoIzq = true;
            mirandoIzq = false;
        }
        //Mirando arriba izq
        if ((movTeclas < 0) && (movTeclasVert>0))
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
            mirandoDcha = false;
            mirandoArribaDcha = false;
            mirandoArribaIzq = true;
            mirandoAbajoDcha = false;
            mirandoAbajoIzq = false;
            mirandoIzq = false;
        }
        //Mirando abajo der
        if ((movTeclas > 0) && (movTeclasVert<0))
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            mirandoDcha = false;
            mirandoArribaDcha = false;
            mirandoArribaIzq = false;
            mirandoAbajoDcha = true;
            mirandoAbajoIzq = false;
            mirandoIzq = false;
        }
        //Mirando arriba der
        if ((movTeclas > 0) && (movTeclasVert>0))
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
            mirandoDcha = false;
            mirandoArribaDcha = true;
            mirandoArribaIzq = false;
            mirandoAbajoDcha = false;
            mirandoAbajoIzq = false;
            mirandoIzq = false;
        }
        //Animacion walking

        if (movTeclas != 0)
        {
            animatorController.SetBool("activaCamina", true);
        }
        else
        {
            animatorController.SetBool("activaCamina", false);

        }

        //Limite abajo

        if (transform.position.y <= -7)
        { 
            Respawnear();
            AudioManagerScript.Instance.SonarClip(AudioManagerScript.Instance.fxDead);
        }

        // 0 vidas

        if(GameManager.vidas <= 0){

            GameManager.muerto = true;

        }

    }

    void FixedUpdate()
    {

        rb.velocity = new Vector2(movTeclas * multiplicador, rb.velocity.y);

    }

    public void Respawnear()
    {
        Debug.Log(GameManager.vidas + " vidas");

        GameManager.vidas= GameManager.vidas -1;

         Debug.Log(GameManager.vidas + " vidas");

        transform.position = respawn.transform.position;
    }


    public void CambiarColor(){

        if(soyazul){
        this.GetComponent<SpriteRenderer>().color = Color.white;
        soyazul = false;
        }else{
            this.GetComponent<SpriteRenderer>().color = Color.blue;
            soyazul = true;
        }

    }
}
