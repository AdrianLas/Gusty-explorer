using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameOverlay : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverlay;

    [SerializeField]
    private TMP_Text pointsCounter;
    public Engine engine;
    private bool active;

    public void Start()
    {
        active = true;
    }
    // Start is called before the first frame update
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
}
