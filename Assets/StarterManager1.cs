using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StarterManager1 : MonoBehaviour
{
    public GameObject panelcommand;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick_Start()
    {
        SceneManager.LoadScene(1);
    }
    public void OnClick_gallery()
    {
        SceneManager.LoadScene(4);
    }
    public void OnClickCommand()
    {
        panelcommand.SetActive(true);
    }
    public void Doquit()

    {
        Debug.Log("has quit game");
        Application.Quit();
    }
    public void OnClick_Menu()
    {
        Debug.Log("returnmenu");
        panelcommand.SetActive(false);
    }
}
