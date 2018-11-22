using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    //public string levelToLoad = "LevelSelect";
    public GameObject ui;
    public GameObject ui2;
    public SceneFader sceneFader;

    public void Play() {
        sceneFader.FadeTo("Level");
    }

    public void Bantuan() {
        ui.SetActive(!ui.activeSelf);
    }

    public void Tentang()
    {
        ui2.SetActive(!ui2.activeSelf);
    }

    public void Quit() {
        Application.Quit();
    }
}
