using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere_Movement : MonoBehaviour
{
    Rigidbody rb;
    

    public GameObject go;
    public float thrust = 1.0f;


    // Start is called before the first frame update
    void Start()
    {   
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        go.transform.position += new Vector3(0, 0, thrust * Time.deltaTime);

    }
}
