using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{

    public float multiplicadorsalto = 5f;
    private Rigidbody2D rb;

    private bool puedosaltar = true;

    private bool activaSaltoFixed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   
        /*Raycast*/
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down,0.5f);
        Debug.DrawRay(transform.position, Vector2.down, Color.magenta);

        /*Puedo Saltar*/
        if(hit){
            puedosaltar=true;
            Debug.Log(hit.collider.name);
        }
        else{
            puedosaltar = false;
        }

        /* Salto*/
        if (Input.GetKeyDown(KeyCode.Space) && puedosaltar==true)
        {

            activaSaltoFixed = true;
           
        }

    }

    void FixedUpdate()
    {
        if(activaSaltoFixed == true){
         rb.AddForce(
                new Vector2(0, multiplicadorsalto),
                ForceMode2D.Impulse);

                activaSaltoFixed=false;
        }

    }


}
