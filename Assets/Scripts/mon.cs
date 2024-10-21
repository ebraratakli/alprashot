using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mon : MonoBehaviour
{
    [SerializeField] public static int DusmanSagligi = 12;
    public GameObject _mons, _dark, hurt, finalDoctor, finalText, gun, flashlight, doctorLight, pan, ammoPanel;
    public static bool monDead = false;
    public GameObject[] allLights, cross;
    public AudioSource monSound, anx, sigh, finalSound;
    public Animator gunAnim;

    public void dusman(int HasarMiktari)
    {
        
        DusmanSagligi -= HasarMiktari;
        _mons.GetComponent<Animator>().SetBool("attack", false);
        _mons.GetComponent<Animator>().SetBool("walk", false);
        _mons.GetComponent<Animator>().SetBool("Dying", false);
        _mons.GetComponent<Animator>().SetBool("Hit", true);
        Invoke("hit", 0.75f);
        
    }

    private void hit()
    {
        _mons.GetComponent<Animator>().SetBool("Hit", false);
    }
    private void Start()
    {
        gunAnim = GameObject.Find("M1911 Handgun_Silver (Shooting)").GetComponent<Animator>();
        allLights[0].SetActive(false);
        allLights[1].SetActive(false);
        allLights[2].SetActive(false);
        finalDoctor.SetActive(false);
        finalText.SetActive(false);
        doctorLight.SetActive(false);
        pan.SetActive(false);
    }

    private void Update()
    {
        if (DusmanSagligi <= 0)
        {
            _mons.GetComponent<Animator>().SetBool("attack", false);
            _mons.GetComponent<Animator>().SetBool("walk", false);
            _mons.GetComponent<Animator>().SetBool("Hit", false);
            _mons.GetComponent<Animator>().SetBool("Dying", true);
            
            Invoke("monOlum", 2);

           
        }

    }

    public void monOlum()
    {
        monDead = true;
        Destroy(gameObject);
        Destroy(monSound);
        Destroy(_dark);
        Destroy(anx);
        gunAnim.GetComponent<Animator>().SetBool("gunAn", false);
        Destroy(gunAnim);
        Destroy(cross[0]);
        Destroy(cross[1]);
        Destroy(cross[2]);
        Destroy(cross[3]);
        Destroy(gun);
        Destroy(flashlight);
        sigh.Play();
        Destroy(hurt);
        Destroy(ammoPanel);

        allLights[0].SetActive(true);
        allLights[1].SetActive(true);
        allLights[2].SetActive(true);
        finalDoctor.SetActive(true);
        doctorLight.SetActive(true);
        finalSound.Play();
        finalText.SetActive(true);
        pan.SetActive(true);
    }

    
}
