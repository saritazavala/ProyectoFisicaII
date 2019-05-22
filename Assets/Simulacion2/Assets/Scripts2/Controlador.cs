using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    public GameObject pauseUI;
    public static bool isPaused;
    public Collider caja;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
        isPaused = false;
        pauseUI.SetActive(false);
        double peso = Variables2.m1 * 9.8;
        float mu = Variables2.f;
        double Fx = (peso * Mathf.Sin(45));
        double Fy = (peso * Mathf.Cos(45));
        double Fr = mu * Fy;
        double ace = (Fx - Fr) / Variables2.m1;
        //double Fr = (Variables2.f*)
        //double Fr = mu * Fy
        //float Fx = 
        //Fy = 
        GameObject.Find("Peso").GetComponent<Text>().text = "Peso: " + Variables2.m1 * 9.8 + " N";
        GameObject.Find("CoeficienteFriccion").GetComponent<Text>().text = "Coeficiente de Friccion 1: " + Variables2.f;

        GameObject.Find("Angulo").GetComponent<Text>().text = "Angulo: 45°";
        GameObject.Find("Aceleracion").GetComponent<Text>().text = "Aceleracion:"+ ace + ""+ " m/s^2 ";
        //a = (Fx - Fr)/m
        //GameObject.Find("sumatoria").GetComponent<Text>().text = "Sumatoria de fuerzas: " + sumatoria + " N";

        caja.material.dynamicFriction = mu;
    }

    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            control();
        }

       
        


    }
    public void control()
    {
        if (isPaused)
        {
            continuar();
        }
        else
        {
            pausar();
        }
    }
    public void continuar()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void pausar()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void reset()
    {
        SceneManager.LoadScene("Sistema1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuS2");
        Time.timeScale = 1f;
    }
}
