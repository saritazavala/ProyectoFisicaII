using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caja : MonoBehaviour
    {
    public Rigidbody cajita;
    public Rigidbody friccion;
    // Start is called before the first frame update
    void Start()
    {
       cajita.mass = Variables2.m1;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
