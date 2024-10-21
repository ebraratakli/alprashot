using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEtme : MonoBehaviour
{
    [SerializeField] private int HasarMiktari = 5;
    [SerializeField] private float HedefUzakligi;
    [SerializeField] private float VerilenUzaklik = 30f;
    RaycastHit Atis;




    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1") && Mermi._cephane != 0)
        {
            Mermi._cephane -= 1;
            int layerMask = LayerMask.GetMask("Zombi");
            if (Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward), out Atis, layerMask))
            {
                HedefUzakligi = Atis.distance;

                if (HedefUzakligi < VerilenUzaklik)
                {
                    Debug.Log("Isabet eden nesne: " + Atis.collider.name);
                    Debug.Log("Isabet eden nesne layer: " + LayerMask.LayerToName(Atis.collider.gameObject.layer));
                    Debug.Log("Isabet noktasý: " + Atis.point);
                    Debug.DrawRay(transform.position, transform.forward * 30f, Color.red);
                    Atis.transform.SendMessage("dusman", HasarMiktari, SendMessageOptions.DontRequireReceiver);
                }
            }

        }
    }
}
