using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{

    public float parallaxNubes = 1f;


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
         transform.position = new Vector3(Camera.main.transform.position.x/parallaxNubes, Camera.main.transform.position.y/parallaxNubes,0);
    }

}
