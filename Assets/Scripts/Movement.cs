using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float multiplicador = 5f;

    private Rigidbody2D rb;
    void Start()
    {
        Debug.Log("Hola mundo");

        rb = GetComponent<Rigidbody2D>();

        transform.position = new Vector3(-9, -1, 0);
    }

    void Update()
    {
        /* Flip */
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        /* Movimiento */
        float movTeclas = Input.GetAxis("Horizontal");

        float miDeltaTime = Time.deltaTime;

        rb.velocity = new Vector2(movTeclas * multiplicador, rb.velocity.y);

    }


}
