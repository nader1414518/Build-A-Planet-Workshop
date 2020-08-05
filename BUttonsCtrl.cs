using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BUttonsCtrl : MonoBehaviour {
    public GameObject pauseMenuPanel;
    public List<GameObject> toBeHidden;

    void Start () {
        if (pauseMenuPanel) {
            pauseMenuPanel.SetActive (false);
        }
    }

    public void StartGame () {
        SceneManager.LoadScene ("GodView", LoadSceneMode.Single);
        Time.timeScale = 1;
    }

    public void QuitGame () {
        Application.Quit ();
    }

    public void MainMenu () {
        SceneManager.LoadScene ("MainMenu", LoadSceneMode.Single);
        Time.timeScale = 1;
    }

    public void PauseGame () {
        if (pauseMenuPanel) {
            pauseMenuPanel.SetActive (true);
            Time.timeScale = 0;
            for (int i = 0; i < toBeHidden.Count; i++) {
                if (toBeHidden[i]) {
                    toBeHidden[i].SetActive (false);
                }
            }
        }
    }

    public void ResumeGame () {
        if (pauseMenuPanel) {
            pauseMenuPanel.SetActive (false);
            Time.timeScale = 1;
            for (int i = 0; i < toBeHidden.Count; i++) {
                if (toBeHidden[i]) {
                    toBeHidden[i].SetActive (true);
                }
            }
        }
    }
}