using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float multiplicador = 5f;

    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola mundo");

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movTeclas = Input.GetAxis("Horizontal");

        float miDeltaTime = Time.deltaTime;

        rb.velocity = new Vector2(movTeclas*multiplicador, rb.velocity.y);

    }


}
