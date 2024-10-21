using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Experimental.GraphView;


public class DoorTrigger : MonoBehaviour
{
    [SerializeField] public bool IsOpen;
    [SerializeField] public GameObject UIObject;
    private Animator _animator;
    public GameObject _gameObject;
    private AudioSource _audioSource;

    private void Awake()
    {
        _animator = GameObject.FindGameObjectWithTag("Door").GetComponent<Animator>();
        _audioSource = GameObject.FindGameObjectWithTag("Door").GetComponent<AudioSource>();
    }
    void Start()
    {
        UIObject.SetActive(false);
        IsOpen = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIObject.SetActive(true); 

            if (Input.GetKeyDown(KeyCode.E))
            {
                IsOpen = !IsOpen;

                if (IsOpen)
                {
                    _animator.SetBool("IsOpen", true);
                    UIObject.SetActive(false);
                    _audioSource.Play();
                }
                else if (!IsOpen)
                {
                    _animator.SetBool("IsOpen", false);
                    UIObject.SetActive(false);
                    _audioSource.Play();  
                }
            }
           
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            UIObject.SetActive(false);
        }
           
    }
   
}
