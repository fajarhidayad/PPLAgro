using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject ui;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Toggle();
        }
    }

    public void Toggle() {
        ui.SetActive(!ui.activeSelf);

        if (ui.activeSelf)
        {
            Time.timeScale = 0f;
            
        }
        else
        {
            Time.timeScale = 1f;
            
        }
    }

    public void Menu() {
        SceneManager.LoadScene("UI");
        Time.timeScale = 1f;
    }

}
