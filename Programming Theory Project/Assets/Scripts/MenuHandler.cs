using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuHandler : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ExitGame();
        }
    }

    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }
    void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
                Application.Quit()
#endif
    }

}
