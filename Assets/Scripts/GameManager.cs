using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static int vidas = 3;

    public static bool muerto = false;

    public static int puntos = 0;

    public static int contadorfantasmas = 0;

    GameObject vidasText;

    void Start()
    {
        vidasText = GameObject.Find("vidas text");
    }

    void Update()
    {
        
       Debug.Log("puntos:" + puntos); 

        Debug.Log("fantasmas asesinados:" + contadorfantasmas); 

        vidasText.GetComponent<TextMeshProUGUI>().text = vidas.ToString();

    }
}
