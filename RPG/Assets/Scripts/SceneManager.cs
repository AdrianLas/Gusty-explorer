using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    #region Variables
    public AudioSource audioButtonHoverPrefab;
    public AudioSource audioButtonClickPrefab;
    public GameObject settingsMenu;
    private GameObject pauseMenu;
    #endregion

    #region Definitions
    public void LoadGameScene()
    {
        StartCoroutine("GameLoading");
    }
    public void OnQuit()
    {
        StartCoroutine("QuitGame");
    }
    public void LoadMainMenuScene()
    {
        StartCoroutine("MainMenuLoading");
    }
    public void OpenSettings()
    {
        settingsMenu.SetActive(true);
    }
    public void OpenSettingsInGame()
    {
        settingsMenu.SetActive(true);
        pauseMenu = GameObject.Find("PauseMenu");
        pauseMenu.SetActive(false);
    }
    public void CloseSettings()
    {
        settingsMenu.SetActive(false);
    }
    public void CloseSettingsInGame()
    {
        settingsMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
    public void OnButtonHover()
    {
        AudioSource tAudio = Instantiate<AudioSource>(audioButtonHoverPrefab, GameObject.Find("AudioSources").transform);
        tAudio.Play();
        Destroy(tAudio.gameObject, 1);
    }
    public void OnButtonClick()
    {
        AudioSource tAudio = Instantiate<AudioSource>(audioButtonClickPrefab, GameObject.Find("AudioSources").transform);
        tAudio.Play();
        Destroy(tAudio.gameObject, 1);
    }
    public IEnumerator GameLoading()
    {
        yield return new WaitForSecondsRealtime(1);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
    public IEnumerator MainMenuLoading()
    {
        yield return new WaitForSecondsRealtime(1);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main_menu");
    }
    public IEnumerator QuitGame()
    {
        yield return new WaitForSecondsRealtime(0.5f);
        Application.Quit();
    }
    #endregion
}
