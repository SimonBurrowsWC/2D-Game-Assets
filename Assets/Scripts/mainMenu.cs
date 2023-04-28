using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public GameObject optionsScreen;
    public Toggle fullScreenTog;
    public List<ResItem> resolutions = new List<ResItem>();
    // Start is called before the first frame update
    void Start()
    {
        optionsScreen.SetActive(false);
        fullScreenTog.isOn = Screen.fullScreen;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void enterGame()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void begone()
    {
        Application.Quit();
    }
    public void enterSettings()
    {
        optionsScreen.SetActive(true);
    }
    public void returnToMenu()
    {
        optionsScreen.SetActive(false);
    }
    public void updateSettings()
    {
        Screen.SetResolution(1920, 1080, fullScreenTog.isOn);
    }

}

[System.Serializable]
public class ResItem
{
    public int horizontal, vertical;
}
