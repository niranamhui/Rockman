using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundmanager : Singleton<Soundmanager>
{
    [SerializeField] private AudioClip soundcoin;
    public AudioSource audioSource;

    public AudioClip Soundcoin
    {
        get
        {
            return soundcoin;
        }
    }
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
}
