using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour

{

private  GameObject rogue;

private Movement movRogue;

    // Start is called before the first frame update
    void Start()
    {
       rogue = GameObject.Find("Rogue"); 

       movRogue = rogue.GetComponent<Movement>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        

        if(col.name == "Rogue"){

          movRogue.Respawnear(); 

        }


    }
}
