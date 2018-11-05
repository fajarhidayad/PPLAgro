﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    //public string levelToLoad = "LevelSelect";
    public SceneFader sceneFader;

    public void Play() {
        sceneFader.FadeTo("Level");
    }

    

    public void Quit() {
        Application.Quit();
    }
}
