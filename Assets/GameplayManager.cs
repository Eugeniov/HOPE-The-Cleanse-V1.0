using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public static GameplayManager Instance;


    public GameObject panelGameOver;
    public GameObject panelVictory;
    public bool startGame;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(gameObject);

        }

    }

    public void ShowVictoryPannel()
    {
        panelVictory.SetActive(true);
    }
    public void ShowGameOver() 
    {
        panelGameOver.SetActive(true);
    }
    public void OnClick_Retry1() 
    { 
        SceneManager.LoadScene(1);
    }
    public void OnClick_Retry2()
    {
        SceneManager.LoadScene(2);
    }
    public void OnClick_Retry3()
    {
        SceneManager.LoadScene(3);
    }
    public void OnClick_Menu()
    {
        SceneManager.LoadScene(0);
    }
}