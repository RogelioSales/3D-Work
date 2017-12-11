using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menus : MonoBehaviour
{
    public Button startLevel;
    public Button credits;
    public Button back;
    public Button exit;

    public void Start()
    {
        startLevel = startLevel.GetComponent<Button>();
        credits = credits.GetComponent<Button>();
        back = back.GetComponent<Button>();
        exit = exit.GetComponent<Button>();

    }

    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }
    public void Credits()
    {
        SceneManager.LoadScene(1);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitGame()
    {
        Debug.Log("Game Exit");
        Application.Quit();
    }

}
