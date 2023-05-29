using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
        Debug.Log("Game Loaded");
    }

#if (!UNITY_EDITOR)
    public void QuitGame()
    {
        Application.Quit();
    }
#endif

}
