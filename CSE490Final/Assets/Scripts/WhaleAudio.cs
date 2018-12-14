using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhaleAudio : MonoBehaviour {

    private AudioSource audioSource;
    private int randomMusic = 0;
    private double randomTime = 10.0;
    private double timeCounter = 0.0;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (timeCounter > randomTime)
        {
            randomTime = Random.Range(15f, 25f);
            timeCounter = 0.0;
            audioSource.Stop();
            audioSource.Play();
        }

        timeCounter += Time.deltaTime;
    }

}
