using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax2 : MonoBehaviour
{

    public float parallaxNubes2 = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void FixedUpdate()
    {
         transform.position = new Vector3(Camera.main.transform.position.x/parallaxNubes2, Camera.main.transform.position.y/parallaxNubes2,0);
    }
}
