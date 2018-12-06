using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour {

    public SceneFader fader;
    public Text nama1;
    public Text nama2;
    public Text nama3;
    public Text nama4;
    public Text nama5;
    string currentUser;

    public void Masuk()
    {
        fader.FadeTo("UI");
    }


    public void Load1()
    {
        PlayerPrefs.SetInt("id", 1);
        currentUser = PlayerPrefs.GetString("Username1");
        PlayerPrefs.SetString("CurrentUser", currentUser);
        Masuk();
    }
    public void Load2()
    {
        currentUser = PlayerPrefs.GetString("Username2");
        PlayerPrefs.SetString("CurrentUser", currentUser);
        PlayerPrefs.GetString("Username2");
        PlayerPrefs.SetInt("id", 2);
        Masuk();
    }
    public void Load3()
    {
        currentUser = PlayerPrefs.GetString("Username3");
        PlayerPrefs.SetString("CurrentUser", currentUser);
        PlayerPrefs.GetString("Username3");
        PlayerPrefs.SetInt("id", 3);
        Masuk();
    }
    public void Load4()
    {
        currentUser = PlayerPrefs.GetString("Username4");
        PlayerPrefs.SetString("CurrentUser", currentUser);
        PlayerPrefs.GetString("Username4");
        PlayerPrefs.SetInt("id", 4);
        Masuk();
    }
    public void Load5()
    {
        currentUser = PlayerPrefs.GetString("Username5");
        PlayerPrefs.SetString("CurrentUser", currentUser);
        PlayerPrefs.GetString("Username5");
        PlayerPrefs.SetInt("id", 5);
        Masuk();
    }
	// Use this for initialization
	void Start () {
        nama1.text = PlayerPrefs.GetString("Username1");
        nama2.text = PlayerPrefs.GetString("Username2");
        nama3.text = PlayerPrefs.GetString("Username3");
        nama4.text = PlayerPrefs.GetString("Username4");
        nama5.text = PlayerPrefs.GetString("Username5");
        PlayerPrefs.GetInt("jumlah");
	}
	
	// Update is called once per frame
	void Update () {
	}
}
