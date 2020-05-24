using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Movement : MonoBehaviour
{
    Rigidbody rb;
    public GameObject go;
    // Start is called before the first frame update
    void Start()
    {
        print("this sphere is meant to move");
        
        rb = GetComponent<Rigidbody>();
        print(rb.useGravity);
        print(go.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
