using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{
    public AudioMixer masterMixer;
    // Start is called before the first frame update
    public void SetMasterVolume(float volume)
    {
        masterMixer.SetFloat("masterVolume", volume);
    }
    public void SetMusicVolume(float volume)
    {
        masterMixer.SetFloat("musicVolume", volume);
    }
    public void SetSoundsVolume(float volume)
    {
        masterMixer.SetFloat("soundsVolume", volume);
    }
}
