using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource  musicSource, sfxSource;    
    public Sound[] musicSound, sfxSound;
    public bool sfxPlayed = false;
    
    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSound, x=> x.name == name);
        if (musicSound != null)
        {
            musicSource.clip = s.soundClip;
            musicSource.loop = true;
            musicSource.Play();
        }
        else
        {
            Debug.LogWarning("Background music clip is not assigned.");
        }
    }

    public void PlaySFX(string name)
    {
        if(sfxPlayed == false)
        {
            Sound s = Array.Find(sfxSound, x=> x.name == name);
        if (s != null)
        {
            sfxSource.PlayOneShot(s.soundClip);   
            sfxPlayed = true;       
        }
        else
        {
            Debug.LogWarning("Background music clip is not assigned.");
        }
        }
        
        
    }
}
