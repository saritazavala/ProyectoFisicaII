using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Variables2 : MonoBehaviour
{
    public static float m1;
    public static float f;
    public static float f2;
    public InputField var1;
    public InputField fr;
    //public InputField fr2;
    // Start is called before the first frame update
    public void inicio()
    {
        m1 = float.TryParse(var1.text, out m1) ? m1 : 0;
        f = float.TryParse(fr.text, out f) ? f : 0;
       


        SceneManager.LoadScene("Sistema1");
    }
}
