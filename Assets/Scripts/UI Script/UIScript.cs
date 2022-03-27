using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
   public void PlayGame()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

    public void QuitGame()
    {
        //if unity editor
        //UnityEditor.EditorApplication.ExitPlaymode();

        Application.Quit();
    }
}
