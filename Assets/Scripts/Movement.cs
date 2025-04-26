using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEditor.Callbacks;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float multiplicador = 5f;

    private Rigidbody2D rb;

    private Animator animatorController;

    GameObject respawn;

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
        
        /* Movimiento */
        float movTeclas = Input.GetAxis("Horizontal");

        float miDeltaTime = Time.deltaTime;

        rb.velocity = new Vector2(movTeclas * multiplicador, rb.velocity.y);

        /* Flip */
        if (movTeclas < 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (movTeclas > 0)
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
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
        { Respawnear();
        }

        // 0 vidas

        if(GameManager.vidas <= 0){

            GameManager.muerto = true;

        }

    }

    public void Respawnear()
    {
        Debug.Log(GameManager.vidas + " vidas");

        GameManager.vidas= GameManager.vidas -1;

         Debug.Log(GameManager.vidas + " vidas");

        transform.position = respawn.transform.position;
    }

}
