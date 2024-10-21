using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Yaklasti : MonoBehaviour
{
    public float Mesafe = Uzaklik.HedefMesafe;
    public GameObject YaziGoster;
    
    private void Update()
    {
        Mesafe = Uzaklik.HedefMesafe;
    }

    private void OnMouseOver()
    {
        if(Mesafe < 2)
        {

            YaziGoster.GetComponent<Text>().text = "Press Q";

        }
    }

    private void OnMouseExit()
    {
        YaziGoster.GetComponent<Text>().text = "";
    }
}
