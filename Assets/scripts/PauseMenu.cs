using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pausemenu;

    public void LoadSceneByBuildIndex(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
    public void pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void home()
    {
        SceneManager.LoadScene("main menu");
        Time.timeScale = 1.0f;

    }
    public void replayfromthestart()
    {
        LoadSceneByBuildIndex(1);
    }
    public void resume()
    {
        pausemenu?.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked;

    }
    public void replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }

}
