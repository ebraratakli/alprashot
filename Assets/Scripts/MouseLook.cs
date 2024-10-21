using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    [SerializeField] float upLookLimit = -90;
    [SerializeField] float downLookLimit = 90;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, upLookLimit, downLookLimit);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * MouseX);


    }
}
