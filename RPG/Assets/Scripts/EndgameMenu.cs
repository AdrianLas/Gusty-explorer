using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EndgameMenu : MonoBehaviour
{
    #region Variables
    private bool endScreenOn;
    [SerializeField]
    private TMP_Text pointsCounter;
    public Engine engine;
    [SerializeField]
    private GameObject endScreenMenu;
    private Image backgroundCover;
    [SerializeField]
    private GameObject gameOverlay;
    private AudioSource[] allAudioSources;
    #endregion

    #region Functions
    public void Start()
    {
        endScreenOn = true;
        endScreenMenu.SetActive(false);
        backgroundCover = endScreenMenu.GetComponent<Image>();
    }

    void Update()
    {
        if(!Movement.isAlive && endScreenOn)
        {
            StartCoroutine(Wait());
        }
    }
    #endregion

    #region Definitions
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
    #endregion
}
