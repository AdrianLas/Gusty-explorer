using UnityEngine;
using UnityEngine.Audio;

public class OptionMenu : MonoBehaviour
{
    #region Variables
    public AudioMixer masterMixer;
    #endregion

    #region Definitions
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
    #endregion
}
