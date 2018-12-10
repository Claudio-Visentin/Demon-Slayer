using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("MainLevel");  
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
