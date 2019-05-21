using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo2 : MonoBehaviour
{
    public Rigidbody cuboB;
    public Rigidbody cuboA;
    // Start is called before the first frame update
    void Start()
    {
        cuboB.mass = variables.m2;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Pillar")
        {
            cuboA.isKinematic = true;
            cuboB.isKinematic = true;
        }
    }

}
