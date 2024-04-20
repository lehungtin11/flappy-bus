using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeScript : MonoBehaviour
{
    [SerializeField] private AudioMixer myMixer;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;
    private void Start()
    {
        // Get previous volume settings
        if (PlayerPrefs.HasKey("volumeMusic"))
        {
            musicSlider.value = PlayerPrefs.GetFloat("volumeMusic");
        }
        if (PlayerPrefs.HasKey("volumeSFX"))
        {
            sfxSlider.value = PlayerPrefs.GetFloat("volumeSFX");
        }

        loadVolume();
    }

    public void loadVolume()
    {   
        // Update previous volume settings
        setMusicVolume();
        setSFXVolume();
    }

    public void setMusicVolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("volumeMusic", volume);
    }

    public void setSFXVolume()
    {
        float volume = sfxSlider.value;
        myMixer.SetFloat("sfx", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("volumeSFX", volume);
    }

    public void setSoundByRef()
    {
        float volumeMusic = 1L;
        float volumeSFX = 1L;
        // Get previous volume settings
        if (PlayerPrefs.HasKey("volumeMusic"))
        {
            volumeMusic = PlayerPrefs.GetFloat("volumeMusic");
        }
        if (PlayerPrefs.HasKey("volumeSFX"))
        {
            volumeSFX = PlayerPrefs.GetFloat("volumeSFX");
        }

        myMixer.SetFloat("music", Mathf.Log10(volumeMusic) * 20);
        myMixer.SetFloat("sfx", Mathf.Log10(volumeSFX) * 20);
    }
}
