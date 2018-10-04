﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    void Start()
    {

    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        AudioListener.volume = volume;

        Debug.Log(volume);
    }
}

