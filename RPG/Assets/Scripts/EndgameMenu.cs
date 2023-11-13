using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndgameMenu : MonoBehaviour
{
    private bool endScreenOn;
    // Start is called before the first frame update
    [SerializeField]
    private TMP_Text pointsCounter;
    public Engine engine;
    [SerializeField]
    private GameObject endScreenMenu;
    private Image backgroundCover;
    [SerializeField]
    private GameObject gameOverlay;
    private AudioSource[] allAudioSources;

    public void Start()
    {
        endScreenOn = true;
        endScreenMenu.SetActive(false);
        backgroundCover = endScreenMenu.GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        if(!Movement.isAlive && endScreenOn)
        {
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        gameOverlay.SetActive(false);
        allAudioSources = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
        foreach (AudioSource audioS in allAudioSources)
        {
            audioS.Stop();
        }

            yield return new WaitForSecondsRealtime(1.5f);
        endScreenMenu.SetActive(true);
        pointsCounter.text = engine.score.ToString();
        endScreenOn = false;
    }
}
