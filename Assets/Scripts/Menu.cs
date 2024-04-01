using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menuWindow;
    [SerializeField] private GameObject _menuButton;
    [SerializeField] private MonoBehaviour[] _scriptsToDisable;

    public void OpenMenuWindow()
    {
        _menuWindow.SetActive(true);
        _menuButton.SetActive(false);

        foreach (var script in _scriptsToDisable)
        {
            script.enabled = false;
        }
        Time.timeScale = 0.01f;
    }

    public void CloseMenuWindow()
    {
        _menuWindow.SetActive(false);
        _menuButton.SetActive(true);

        foreach (var script in _scriptsToDisable)
        {
            script.enabled = true;
        }
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
