using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    #region Variables
    public GameObject pauseMenu;
    public static bool isPaused;
    public Engine engine;
    #endregion

    #region Functions
    void Start()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
    }

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
    #endregion

    #region Definitions
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
    #endregion
}
