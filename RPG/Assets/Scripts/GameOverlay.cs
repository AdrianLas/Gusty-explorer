using UnityEngine;
using TMPro;

public class GameOverlay : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private GameObject gameOverlay;
    [SerializeField]
    private TMP_Text pointsCounter;
    public Engine engine;
    private bool active;
    #endregion

    #region Functions
    public void Start()
    {
        active = true;
    }
    private void FixedUpdate()
    {
        pointsCounter.text = engine.score.ToString();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Movement.isAlive)
        {
            if (active)
            {
                HideMenuButton();
            }
            else
            {
                ShowMenuButton();
            }
        }
    }
    #endregion

    #region Definitions
    public void ShowMenuButton()
    {
        gameOverlay.SetActive(true);
        active = true;
    }
    public void HideMenuButton()
    {
        gameOverlay.SetActive(false);
        active = false;
    }
    #endregion
}
