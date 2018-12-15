using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject loading;
    public GameObject instructions;

    public void StartGame()
    {
        SceneManager.LoadScene("MainLevel");
        loading.SetActive(true);
    }

    public void OnQuit()
    {
        Application.Quit();
    }

    public void OpenInstructions ()
    {
        instructions.SetActive(true);
    }
    public void CloseInstructions()
    {
        instructions.SetActive (false);
    }
}
