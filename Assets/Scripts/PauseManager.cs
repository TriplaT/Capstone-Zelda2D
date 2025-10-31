using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    private bool isPaused;
    public string mainMenu = "StartMenu";
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("pause")) {
            ChangePause();
        }
    }

    public void ChangePause() {
        isPaused = !isPaused;
        if (isPaused) {
            pausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
        else {
            pausePanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void QuitToMainMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenu);
    }
}
