using UnityEngine;

public class IncreaseVolume : MonoBehaviour
{
    #region Variables
    private AudioSource audioSource;
    #endregion

    #region Functions
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

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
    #endregion
}
