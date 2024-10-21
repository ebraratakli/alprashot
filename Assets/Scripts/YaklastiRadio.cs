using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class YaklastiRadio : MonoBehaviour
{
    public float Mes = Uzaklik.HedefMesafe;
    public GameObject Yazi;
    
    private void Update()
    {
        Mes = Uzaklik.HedefMesafe;
    }

    private void OnMouseOver()
    {
        if(Mes < 5)
        {

            Yazi.GetComponent<Text>().text = "(T)urn Off";

        }
    }

    private void OnMouseExit()
    {
        Yazi.GetComponent<Text>().text = "";
    }
}
