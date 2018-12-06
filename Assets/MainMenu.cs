using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    //public string levelToLoad = "LevelSelect";
    public GameObject ui;
    public GameObject ui2;
    public Text nama;
    
    public SceneFader sceneFader;

    public void Start() {
        nama.text = PlayerPrefs.GetString("CurrentUser");
    }

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

    public void GantiAkun() {
        sceneFader.FadeTo("UserSelect");
    }

}
