using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void TurnOnUI(Canvas canvas)
    {
        canvas.gameObject.SetActive(true);
    }

    public void TurnOffUI(Canvas canvas)
    {
        canvas.gameObject.SetActive(false);
    }
}
