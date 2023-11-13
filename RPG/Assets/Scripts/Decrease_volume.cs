using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Decrease_volume : MonoBehaviour
{
    public int scoreTreshold;
    private AudioSource soundSource;
    private float volume;
    private Engine engine;
    private Scene scene;
    public GameObject prefab;
    private int NewAreaReached;
    private GameObject holder;
    // Start is called before the first frame update
    void Start()
    {

        soundSource = GetComponent<AudioSource>();
        engine = FindObjectOfType<Engine>();
        NewAreaReached = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (engine.score >= scoreTreshold)
        {
            if (NewAreaReached == 0)
            {
                holder = Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
                holder.transform.parent = gameObject.transform.parent;
                NewAreaReached = 1;
            }
            volume = soundSource.volume;
            if (volume != 0)
            {
                soundSource.volume = volume - 0.5f * Time.deltaTime;
            }
            if (soundSource.volume <= 0)
            {
                Destroy(gameObject);
            }
        }

    }
}
