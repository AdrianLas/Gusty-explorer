using UnityEngine;

public class Decrease_volume : MonoBehaviour
{
    #region Variables
    public int scoreTreshold;
    private AudioSource soundSource;
    private float volume;
    private Engine engine;
    public GameObject prefab;
    private int NewAreaReached;
    private GameObject holder;
    #endregion

    #region Functions
    void Start()
    {
        soundSource = GetComponent<AudioSource>();
        engine = FindObjectOfType<Engine>();
        NewAreaReached = 0;
    }

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
    #endregion
}
