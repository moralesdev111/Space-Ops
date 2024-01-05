using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;
    public AudioClip radioIntroductionClip;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void PlayRadioIntroductionMessage(AudioClip audioClip)
    {
        SFXSource.PlayOneShot(audioClip);
    }
}
