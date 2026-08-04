using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public static Scene Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
   
    public void LoadTitle()
    {
               SceneManager.LoadScene("TitleScene");
    }
    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene1");
    }

    public void LoadResult()
            {
        SceneManager.LoadScene("ResultScene");
    }
}
