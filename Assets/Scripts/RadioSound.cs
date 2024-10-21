using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using Unity.VisualScripting;

public class RadioSound : MonoBehaviour
{
    [SerializeField] public AudioSource radio_AudioSource, breathe;
    public AudioSource _audio;
    public GameObject _dark, _find;
    public Animator _an;


    private void Start()
    {
        radio_AudioSource = GetComponent<AudioSource>();
        breathe = GameObject.Find("player").GetComponent<AudioSource>();
        _audio = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();
        radio_AudioSource.mute = true;
        breathe.mute = true;
        _find.SetActive(false);
        _dark.SetActive(false);
    }
    void Update()
    {
        if (Dusman6.zombieDead)
        {
            StartCoroutine(PlaySound());

            radio_AudioSource.mute = false;
            _find.SetActive(true);
            _dark.SetActive(true);
            PlayerMovement._speed = 6.5f;
            PlayerMovement._Xspeed = 0f;
            _an.SetBool("gunAn", true);
            breathe.mute = false;

        }
    }
    IEnumerator PlaySound()
    {
        _audio.Stop();

        yield return new WaitForSeconds(7f);

    }
}
