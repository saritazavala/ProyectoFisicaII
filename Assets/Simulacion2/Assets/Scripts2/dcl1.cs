using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dcl1 : MonoBehaviour
{
    public GameObject diagramas;
    public bool activo;

    // Start is called before the first frame update
    void Start()
    {
        activo = false;
}

    public void Show()
    {
        if (activo == false)
        {
            diagramas.SetActive(true);
            activo = true;
        }
        else
        {
            diagramas.SetActive(false);
            activo = false;
        }
    }
}

