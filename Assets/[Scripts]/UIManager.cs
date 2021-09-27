using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("Main");
    }

    public void OnBackButtonClicked()
    {
        SceneManager.LoadScene("Start");
    }

    public void OnNextButtonClicked()
    {
        SceneManager.LoadScene("End");
    }
}
