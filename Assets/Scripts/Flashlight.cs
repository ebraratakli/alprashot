using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
    public float Mesafe = Uzaklik.HedefMesafe;
    public GameObject flashlight, _Light, realFlashlight, triggerLight;
    public AudioSource _almaSesi;
    
    void Start()
    {
        _Light.SetActive(false);
        realFlashlight.SetActive(false);
        
    }

    private void OnMouseOver()
    {
        if (Mesafe <= 2 && Input.GetKeyDown(KeyCode.F))
        {
            FenerAlindi();
        }
    }
    void FenerAlindi()
    {
        _almaSesi.Play();
        _Light.SetActive(true);
        realFlashlight.SetActive(true);
        Destroy(flashlight);
        Destroy(triggerLight);
    }
}
