using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class variables : MonoBehaviour
{
    public static int m1;
    public static int m2;
    public InputField var1;
    public InputField var2;
    // Start is called before the first frame update
    public void inicio()
    {
        m1 = int.TryParse(var1.text, out m1) ? m1 : 0;
        m2 = int.TryParse(var2.text, out m2) ? m2 : 0;
        SceneManager.LoadScene("Polea");
    }
}
