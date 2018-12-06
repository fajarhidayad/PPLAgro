using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

    public GameObject ui;
    public SceneFader sceneFader;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Toggle();
        }
    }

    public void Berhenti() {
        ui.SetActive(!ui.activeSelf);
        Time.timeScale = 0f;
    }

    public void Lanjut() {
        ui.SetActive(!ui.activeSelf);
        Time.timeScale = 1f;
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
        sceneFader.FadeTo("UI");
        Time.timeScale = 1f;
    }

}
