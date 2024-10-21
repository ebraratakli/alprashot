using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sarjor : MonoBehaviour
{
    [SerializeField] private AudioSource _ses;
    public GameObject mermi, _gameObject;
    public int sarjor,Ysarjor,yEkran;
    [SerializeField] private Animator _animator;

    private void Start()
    {
        _animator = _gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        sarjor = Mermi._cephane;
        Ysarjor = Mermi.yCephane;

        if(Ysarjor == 0)
        {
            yEkran = 0;
        }
        else
        {
            yEkran = 10 - sarjor;
        }

        if(sarjor <= 0)
        {
            
            mermi.GetComponent<Mermi>().enabled = false;  
        }
        else
        {
            
            mermi.GetComponent<Mermi>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            

            if (yEkran >= 1)
            {
                if(Ysarjor <= yEkran)
                {
                    _animator.SetBool("sarjor", true);
                    Mermi._cephane += Ysarjor;
                    Mermi.yCephane -= Ysarjor;
                    ActionReload();
                }
                else
                {
                    _animator.SetBool("sarjor", true);
                    Mermi._cephane += yEkran;
                    Mermi.yCephane -= yEkran;
                    ActionReload();
                }
            }
            StartCoroutine(EnableScript());
        }
    }

    IEnumerator EnableScript()
    {
        yield return new WaitForSeconds(1f);
        
        _animator.SetBool("sarjor", false);
    }

    void ActionReload()
    {
        
        _ses.Play();
    }
}
