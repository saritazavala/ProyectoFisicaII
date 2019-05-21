using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public GameObject pauseUI;
    public static bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        pauseUI.SetActive(false);
        GameObject.Find("peso1").GetComponent<Text>().text = "Peso 1: " + variables.m1*9.8 + " N";
        GameObject.Find("peso2").GetComponent<Text>().text = "Peso 2: " + variables.m2 * 9.8+" N";
        double a = variables.m1*9.8;
        double b = variables.m2*9.8;
        double sumatoria = a - b;
        GameObject.Find("sumatoria").GetComponent<Text>().text = "Sumatoria de fuerzas: " + sumatoria + " N";
    }

    // Update is called once per frame
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
    void continuar()
    {
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void pausar()
    {
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void reset()
    {
        SceneManager.LoadScene("Polea");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MenuVaria");
        Time.timeScale = 1f;
    }
}
