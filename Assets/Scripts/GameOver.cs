

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject ui;
    public GameManagerBehavior gameManager;

    void RestartLevel()
    {
      //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Time.timeScale = 0f;
        if (gameManager.getGame() == 1)
        {
            Debug.Log("Menang");
            WinLevel();
        }
        else {
            Debug.Log("Kalah");
            LoseLevel();
        }

    }

    void WinLevel() {
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

    void LoseLevel() {
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

}
