

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject ui;

    void RestartLevel()
    {
      //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 0f;


    }

}
