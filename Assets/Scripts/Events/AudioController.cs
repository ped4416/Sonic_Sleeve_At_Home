using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class AudioController : MonoBehaviour
{
    public const string audioName = "song.wav";

    [Header("Audio Stuff")]
    public AudioSource audioSource;
    public AudioClip audioClip;
    public string soundPath;

    private void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        //filepath needs to work on multiple machines. To do!
        soundPath = "C://Users//UCLH_RehabKit_12//Documents//Unity Projects//samples";
        Debug.Log("Loading file");
        StartCoroutine(GetAudioClip());
    }

    IEnumerator GetAudioClip()
    {
        using (UnityWebRequest uwr = UnityWebRequestMultimedia.GetAudioClip(soundPath + "//song.wav", AudioType.WAV))
        {

            yield return uwr.SendWebRequest();

            //may need a pause here? 
            audioClip = DownloadHandlerAudioClip.GetContent(uwr);
            audioSource.clip = audioClip;
            //audioSource.isReadyToPLay();
            Debug.Log("File Ready");
        }
    }

    public void PlayAudioFile()
    {
        //audioSource.clip = audioClip;
        audioSource.Play();
        audioSource.loop = true;
        Debug.Log("Play file");
    }
    public void PauseAudioFile()
    {
        //audioSource.clip = audioClip;
        audioSource.Pause();
        Debug.Log("Pause file");
    }

    public void StopAudioFile()
    {
        //audioSource.clip = audioClip;
        audioSource.Stop();
        Debug.Log("Stop file");
    }

}

