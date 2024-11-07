using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Ensure an AudioSource component is attached to the GameObject
[RequireComponent(typeof(AudioSource))]
public class AudioPeer : MonoBehaviour
{
    AudioSource _audioSource; // Reference to the AudioSource component
    public static float[] _samples = new float[512]; // Array to store audio sample data

    // Initialize AudioSource component
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update audio samples each frame
    void Update()
    {
        GetSpectrumAudioSource();
    }

    // Retrieve spectrum data from the audio source
    void GetSpectrumAudioSource()
    {
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }
}
