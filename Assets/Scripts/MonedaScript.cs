using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaScript : MonoBehaviour
{
   
  Animator monedaController;
    void Start()
    {
        
    }

    
    void Update()
    {
        monedaController = this.GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        
        if(col.name == "Rogue"){
            GameManager.puntos += 1;

              monedaController.SetBool("monedaDestruir", true);

            Destroy(this.gameObject, 1.5f);
        }
    }
}
