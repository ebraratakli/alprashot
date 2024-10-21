 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doc : MonoBehaviour
{
    public GameObject _doc, _text, docLight;



    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            StartCoroutine(vanish());
            Destroy(_doc);
            Destroy(_text);
            Destroy(docLight);
        }
    }

    IEnumerator vanish() 
    {
        yield return new WaitForSeconds(3.0f);
    }

}
