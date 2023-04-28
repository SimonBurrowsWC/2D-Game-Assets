using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevel : MonoBehaviour
{
    public string level;
    public void LoadGame()
    {
        SceneManager.LoadScene(level);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "NextLevel")
        {
            LoadGame();
        }
    }
}
