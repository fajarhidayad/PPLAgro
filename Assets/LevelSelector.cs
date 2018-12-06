using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour {

    public SceneFader fader;

    public Button[] levelButtons;

    int levelReached;

    public int getId() {
        if (PlayerPrefs.GetInt("id") == 1)
        {
            levelReached = PlayerPrefs.GetInt("level1");
        }
        else if (PlayerPrefs.GetInt("id") == 2)
        {
            levelReached = PlayerPrefs.GetInt("level2");
        }
        else if (PlayerPrefs.GetInt("id") == 3)
        {
            levelReached = PlayerPrefs.GetInt("level3");
        }
        else if (PlayerPrefs.GetInt("id") == 4)
        {
            levelReached = PlayerPrefs.GetInt("level4");
        }
        else if (PlayerPrefs.GetInt("id") == 5)
        {
            levelReached = PlayerPrefs.GetInt("level5");
        }
        return levelReached;
    }

    void Start() {
        getId();
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false;
            }
            
        }
    }

    public void Select(string levelName) {
        fader.FadeTo(levelName);
    }

    public void Back()
    {
        fader.FadeTo("UI");
    }
}
