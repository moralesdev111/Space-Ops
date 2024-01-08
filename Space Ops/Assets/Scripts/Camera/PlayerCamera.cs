using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [Header("Camera Sensitivity Axis")]
    [SerializeField] float sensitivityX;
    [SerializeField] float sensitivityY;

    [SerializeField] Transform orientation;

    private float xRotation;
    private float yRotation;


    void Start()
    {
        //CursorHandling();
    }

    
    void Update()
    {
        CameraRotationHandling();
    }


    private void CameraRotationHandling()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensitivityX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensitivityY;

        yRotation += mouseX;
        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }

    private void CursorHandling()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

}
