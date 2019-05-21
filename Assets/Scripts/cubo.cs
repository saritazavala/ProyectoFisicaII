using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    public Rigidbody cuboA;
    public Rigidbody cuboB;
    // Start is called before the first frame update
    void Start()
    {
        cuboA.mass = variables.m1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Pillar")
        {
            cuboA.isKinematic = true;
            cuboB.isKinematic = true;
        }
    }
    
}
