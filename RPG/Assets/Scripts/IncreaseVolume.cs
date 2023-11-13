using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseVolume : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (audioSource.volume < 1)
        {
            audioSource.volume += 0.5f * Time.deltaTime;
        }
        if (audioSource.volume >= 1)
        {
            Destroy(this);
        }
    }
}
