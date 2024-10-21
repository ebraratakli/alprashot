using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class TurnOff : MonoBehaviour
{
    public float Mes = Uzaklik.HedefMesafe;
    public AudioSource _radio;
    public GameObject _find;
    
    [SerializeField] GameObject _monster;
    public AudioSource mon;


    private void Start()
    {
        _radio = GameObject.Find("radioo").GetComponent<AudioSource>();
        _monster.SetActive(false);
        mon.mute = true;
        
    }
    private void OnMouseOver()
    {
        if (Mes <= 5 && Input.GetKeyDown(KeyCode.T))
        {
            mon.mute = false;
            Destroy(_radio);
            Destroy(_find);
            _monster.SetActive(true);
            

        }
    }
    


}
