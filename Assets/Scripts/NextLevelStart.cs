using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelStart : MonoBehaviour
{
    [SerializeField] private string storyScene;
    public void NewGame()
    {
     
        SceneManager.LoadScene("StoryScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
