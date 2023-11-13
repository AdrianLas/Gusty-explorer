using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OnSliderAwake : MonoBehaviour
{
    #region Variables
    public AudioMixer audioMixer;
    public Slider masterVolumeSlider;
    public Slider musicVolumeSlider;
    public Slider soundVolumeSlider;
    #endregion

    #region Functions
    void Start()
    {
        float masterVolume, musicVolume, soundsVolume;
        audioMixer.GetFloat("masterVolume",out masterVolume);
        masterVolumeSlider.value = masterVolume;
        audioMixer.GetFloat("musicVolume", out musicVolume);
        musicVolumeSlider.value = musicVolume;
        audioMixer.GetFloat("soundsVolume", out soundsVolume);
        soundVolumeSlider.value = soundsVolume;
    }
    #endregion
}
