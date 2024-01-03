using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    [SerializeField] Transform cameraPosition;


    void Update()
    {
        UpdateCameraPosition();
    }


    private void UpdateCameraPosition()
    {
        transform.position = cameraPosition.position;
    }
}
