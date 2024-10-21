using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KalanCan : MonoBehaviour
{
    public static float OyuncuCan = 100;
    public float icCan;
    public Slider slider;

    public void Update()
    {
        icCan = OyuncuCan;

        slider.value = icCan;

        if(icCan <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }


}
