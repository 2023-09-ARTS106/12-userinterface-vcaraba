using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public Animator startButton;
    public Animator settingsButton;
    public Animator dialog;
    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }
    public void OpenSettings()
    {
        startButton.SetBool("IsHidden", true);
        settingsButton.SetBool("IsHidden", true);
        dialog.SetBool("IsHidden", false);
    }
    public void CloseSettings()
    {
        startButton.SetBool("IsHidden", false);
        settingsButton.SetBool("IsHidden", false);
        dialog.SetBool("IsHidden", true);
    }
}
