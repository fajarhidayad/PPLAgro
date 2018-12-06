using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;

public class Player : MonoBehaviour {

    public string Nama;
    public int Koin;
    public int Score;
    public int Level;

    void Save() {
        JSONObject playerJson = new JSONObject();
        playerJson.Add("Name", Nama);
        playerJson.Add("Koin", Koin);
        playerJson.Add("Score", Score);
        playerJson.Add("Level", Level);

        string path = Application.persistentDataPath + "/PlayerSave.json";
        File.WriteAllText(path, playerJson.ToString());

    }

    void Load() {
        string path = Application.persistentDataPath + "/PlayerSave.json";
        string jsonString = File.ReadAllText(path);
        JSONObject playerJson = (JSONObject)JSON.Parse(jsonString);
        Nama = playerJson["Name"];
        Koin = playerJson["Koin"];
        Score = playerJson["Score"];
        Level = playerJson["Level"];
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
