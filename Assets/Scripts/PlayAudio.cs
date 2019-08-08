using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    [SerializeField] private AudioClip successClip;
    [SerializeField] private AudioClip guessClip;

    private AudioSource source;

    // Start is called before the first frame update
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    public void PlaySuccessClip()
    {
        source.PlayOneShot(successClip);
    }

    public void PlayGuessClip()
    {
        source.PlayOneShot(guessClip);
    }
}
