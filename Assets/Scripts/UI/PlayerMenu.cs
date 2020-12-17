using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class PlayerMenu : MonoBehaviour
{
    public bool menuOpen = false;
    public GameObject PlayerMenuUI;
    public GameObject TheCharacter;


    public void RestartLevel()
    {
        SceneManager.LoadScene(2);
        TheCharacter.GetComponent<FirstPersonController>().enabled = true;
        PlayerMenuUI.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        menuOpen = false;
        Time.timeScale = 1;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
        TheCharacter.GetComponent<FirstPersonController>().enabled = true;
        PlayerMenuUI.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        menuOpen = false;
        Time.timeScale = 1;
    }
    void Update()
    {
        if (Input.GetButtonDown("Cancel")) 
        {
            if (menuOpen == false)
            {
                Time.timeScale = 0;
                menuOpen = true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                PlayerMenuUI.SetActive(true);
                TheCharacter.GetComponent<FirstPersonController>().enabled = false;
            }
            else
            {
                TheCharacter.GetComponent<FirstPersonController>().enabled = true;
                PlayerMenuUI.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                menuOpen = false;
                Time.timeScale = 1;
            }
        }
    }

}
