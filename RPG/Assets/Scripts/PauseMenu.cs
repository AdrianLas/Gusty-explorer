using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    public Engine engine;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Movement.isAlive)
        {
            if(isPaused)
            {
                ResumeGame();
                
            }
            else
            {
                PauseGame();
            }
        }
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        if (engine.started)
        {
            Time.timeScale = 0f;
        }
        isPaused = true;
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        if (engine.started)
        {
            Time.timeScale = 1f;
        }
        isPaused = false;
    }
}
