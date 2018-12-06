using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class TambahUser : MonoBehaviour {

    public GameObject username;
    public string Username;
    private string form;
    public GameObject ui;
    public Text nama1;
    public Text nama2;
    public Text nama3;
    public Text nama4;
    public Text nama5;

	// Use this for initialization
	void Start () {
        nama1.text = PlayerPrefs.GetString("Username1");
	}

    public void Tambah() {
        if (PlayerPrefs.GetInt("jumlah") == 0)
        {
            Save1();
        }
        else if (PlayerPrefs.GetInt("jumlah") == 1)
        {
            Save2();
        }
        else if (PlayerPrefs.GetInt("jumlah") == 2)
        {
            Save3();
        }
        else if (PlayerPrefs.GetInt("jumlah") == 3)
        {
            Save4();
        }
        else if (PlayerPrefs.GetInt("jumlah") == 4)
        {
            Save5();
        }
    }

    public void Save1()
    {
        Username = username.GetComponent<InputField>().text;
        nama1.text = Username;
        PlayerPrefs.SetString("Username1", Username);
        ui.SetActive(!ui.activeSelf);
        PlayerPrefs.SetInt("level1", 1);
        PlayerPrefs.SetInt("jumlah", 1);
    }

    public void Save2()
    {
        Username = username.GetComponent<InputField>().text;
        nama2.text = Username;
        PlayerPrefs.SetString("Username2", Username);
        ui.SetActive(!ui.activeSelf);
        PlayerPrefs.SetInt("jumlah", 2);
        PlayerPrefs.SetInt("level2", 1);
    }

    public void Save3()
    {
        Username = username.GetComponent<InputField>().text;
        nama3.text = Username;
        PlayerPrefs.SetString("Username3", Username);
        ui.SetActive(!ui.activeSelf);
        PlayerPrefs.SetInt("jumlah", 3);
        PlayerPrefs.SetInt("level3", 1);
    }

    public void Save4()
    {
        Username = username.GetComponent<InputField>().text;
        nama4.text = Username;
        PlayerPrefs.SetString("Username4", Username);
        ui.SetActive(!ui.activeSelf);
        PlayerPrefs.SetInt("jumlah", 4);
        PlayerPrefs.SetInt("level4", 1);
    }

    public void Save5()
    {
        Username = username.GetComponent<InputField>().text;
        nama5.text = Username;
        PlayerPrefs.SetString("Username5", Username);
        ui.SetActive(!ui.activeSelf);
        PlayerPrefs.SetInt("jumlah", 5);
        PlayerPrefs.SetInt("level5", 1);
    }

    public void TambahButton() {
        ui.SetActive(!ui.activeSelf);
    }

    public void CancelButton()
    {
        ui.SetActive(!ui.activeSelf);
    }

	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            TambahButton();
        }
	}
}
