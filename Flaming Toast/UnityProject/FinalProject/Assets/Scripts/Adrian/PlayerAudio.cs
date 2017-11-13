using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour {

    static public PlayerAudio instance;
    public GameObject audioGameObject;
    


    private void Awake()
    {
        instance = this;
    }

    public void PlaySound(AudioClip audio)
    {
        //instantiate
        GameObject audioObject = Instantiate(audioGameObject);
        AudioSource audioSource = audioObject.GetComponent<AudioSource>();
        audioSource.PlayOneShot(audio, 1.0f);
    }
}
