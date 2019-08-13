using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource[] listOfAudioSources;
    public bool sickoMode = false;

    public void PlaySound()
    {
        listOfAudioSources[0].Play();
    }

    public void StopSound()
    {
        listOfAudioSources[0].Stop();
    }

    public void SickoMode()
    {
        if (listOfAudioSources.Length == 2)
        {
            listOfAudioSources[1].Play();
        }
        sickoMode = true;
    }

    public void StopSickoMode()
    {
        listOfAudioSources[1].Stop();
        sickoMode = false;
    }
}
