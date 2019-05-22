using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controladoe2 : MonoBehaviour
{
    public GameObject pauseUI;
    public static bool isPaused;
    public Collider caja;
    public Collider caja2;


    // Start is called before the first frame update
    void Start()
    {

        isPaused = false;
        pauseUI.SetActive(false);
        double peso = masV.m1 * 9.8;
        double peso2 = masV.m2 * 9.8;
        float mu = masV.f;
        double Fx = (peso * Mathf.Sin(45));
        double Fy = (peso * Mathf.Cos(45));
        double Fr = mu * Fy;

        //aceleracion masa 1
        // (Friccion - Fx-Fr1 -Fr2)/m1  = a
        double ace = (Fx - Fr) / masV.m1;


        double Fx2 = (peso2 * Mathf.Sin(45));
        double Fy2 = (peso2 * Mathf.Cos(45));
        double Fr2 = mu * Fy2;
        double ace2 = (Fr2 - Fx2) / masV.m2;
        //a2 = (Fr2 - fx2 )/ m2


        //double Fr = (Variables2.f*)
        //double Fr = mu * Fy
        //float Fx = 
        //Fy = 
        //a  =  friccion - pesox -fr1  -fr12 /m1
        GameObject.Find("Peso").GetComponent<Text>().text = "Peso1: " + masV.m1 * 9.8 + " N";
        GameObject.Find("Peso2").GetComponent<Text>().text = "Peso2: " + masV.m2 * 9.8 + " N";
        GameObject.Find("CoeficienteFriccion").GetComponent<Text>().text = "Coeficiente de Friccion 1: " + masV.f;
        GameObject.Find("fri").GetComponent<Text>().text = "Coeficiente de Friccion 2: " + masV.f2;
        GameObject.Find("Angulo").GetComponent<Text>().text = "Angulo: 45°";
        GameObject.Find("Aceleracion1").GetComponent<Text>().text = "Aceleracion1: " + ""+ ace + " m/s^2 ";
        GameObject.Find("Aceleracion2").GetComponent<Text>().text = "Aceleracion2: " + "" + ace2 + " m/s^2 ";


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
        SceneManager.LoadScene("Sistemacon2");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menucon2");
        Time.timeScale = 1f;
    }
}
