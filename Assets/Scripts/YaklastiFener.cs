using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YaklastiFener : MonoBehaviour
{
    public float Mesafe = Uzaklik.HedefMesafe;
    public GameObject YaziiiGoster;

    private void Update()
    {
        Mesafe = Uzaklik.HedefMesafe;
    }

    private void OnMouseOver()
    {
        if (Mesafe < 2)
        {

            YaziiiGoster.GetComponent<Text>().text = "Press F";

        }
    }

    private void OnMouseExit()
    {
        YaziiiGoster.GetComponent<Text>().text = "";
    }
}
