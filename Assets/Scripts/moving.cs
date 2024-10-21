using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    public AudioSource footSteps;
    void Start()
    {
        _animator = GetComponent<Animator>();
        footSteps = GameObject.FindGameObjectWithTag("footstep").GetComponent<AudioSource>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            footSteps.enabled=true;
            _animator.SetBool("moving", true);
            
        }

        else
        {
            footSteps.enabled = false;
            _animator.SetBool("moving", false);
            
        }
            
    }
}
