using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySliderRotate : MonoBehaviour
{
    [SerializeField] Slider healthSlider;
    [SerializeField] Transform player;
    

    void Update()
    {
        MakeSliderFacePlayerRotation();
    }

    private void MakeSliderFacePlayerRotation()
    {
        healthSlider.transform.LookAt(player);
    }
}
