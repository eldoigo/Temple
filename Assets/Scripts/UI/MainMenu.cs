using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject sidePanel;
    public GameObject ClickHereButton;
    public GameObject StartingText;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void SlidePanel()
    {
        sidePanel.GetComponent<Animation>().Play("MenuUI");
        ClickHereButton.SetActive(false);
        StartingText.SetActive(false);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
