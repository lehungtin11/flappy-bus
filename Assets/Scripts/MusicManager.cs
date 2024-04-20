using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] VolumeScript volumeScript;

    [Header("----- Audio Source -----")]
    [SerializeField] AudioSource music;
    [SerializeField] AudioSource SFX;

    [Header("----- Audio Clip -----")]

    public AudioClip background;
    public AudioClip flap;
    public AudioClip hit;
    public AudioClip die;
    public AudioClip point;
    public AudioClip click;

    private void Start()
    {
        music.clip = background;
        music.Play();

        Button[] buttons = FindObjectsOfType<Button>(true); // parameter makes it include inactive UI elements with buttons
        foreach (Button b in buttons)
        {
            b.onClick.AddListener(ButtonSound);
        }

        // Update previous volume settings
        volumeScript.setSoundByRef();
    }
    public void ButtonSound()
    {
        PlaySFX(click);
    }
    public void PlaySFX(AudioClip clip)
    {
        SFX.PlayOneShot(clip);
    }
}
