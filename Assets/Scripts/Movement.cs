using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float multiplicador = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hola mundo");
    }

    // Update is called once per frame
    void Update()
    {
        float movTeclas = Input.GetAxis("Horizontal");

        /* transform.position = new Vector3(transform.position.x + (movTeclas/100), transform.position.y, 0);*/

        //Debug.Log(Input.GetAxis("Horizontal"));

        float miDeltaTime = Time.deltaTime;

        transform.Translate(movTeclas*(Time.deltaTime*multiplicador), 0, 0);
    }


}
