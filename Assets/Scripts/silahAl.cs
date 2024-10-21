using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class silahAl : MonoBehaviour
{
    public float Mesafe = Uzaklik.HedefMesafe;
    public GameObject anaSilah, yedekSilah, cephane, gunLight;
    public AudioSource almaSesi;
    public GameObject _Level1;
    public float gorunmeSure = 2.2f;
    public AudioSource _gameSound;
    public GameObject[] cross;
    public GameObject Cephanee, panel;
    public AudioSource level;



    private void Start()
    {
      
        anaSilah.SetActive(false);
        cephane.SetActive(false);
        cross[0].SetActive(false);
        cross[1].SetActive(false);
        cross[2].SetActive(false);
        cross[3].SetActive(false);
        Cephanee.SetActive(false);
        panel.SetActive(false);
        
    }

    private void OnMouseOver()
    {
        if (Mesafe <= 2 && Input.GetKeyDown(KeyCode.Q))
        {       
            silahAlindi();
        }
    }
   
    void silahAlindi()
    {
        almaSesi.Play();
        transform.position = new Vector3 (0,-50,0);
        yedekSilah.SetActive(false);
        anaSilah.SetActive (true);
        cephane.SetActive (true);
        panel.SetActive(true);
        _Level1.GetComponent<Text>().text = "LEVEL 1: ANXIETY";
        Invoke("MesajiSil", gorunmeSure);
        panel.SetActive(true);
        level.Play();
        _gameSound.Play();
        cross[0].SetActive(true);
        cross[1].SetActive(true);
        cross[2].SetActive(true);
        cross[3].SetActive(true);
        Cephanee.SetActive(true);
        Destroy(gunLight);

    }
    private void MesajiSil()
    {
        _Level1.GetComponent<Text>().text = "";
        panel.SetActive(false);
    }
}
