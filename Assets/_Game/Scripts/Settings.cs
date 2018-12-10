using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {

    Scene m_scene;
    public static bool gamepad;

	void Start () {
        Screen.SetResolution(640, 480, true);
        Application.targetFrameRate = 60;
        DontDestroyOnLoad(this.gameObject);
    }

    private void FixedUpdate()
    {
        m_scene = SceneManager.GetActiveScene();
    }
    public void Gamepad(bool value)
    {
        if (value == true)
        {
            gamepad = true;
        }
        else
        {
            gamepad = false;
        }
    }
        void Update () {
		if (Input.GetKey (KeyCode.Escape) | Input.GetKey (KeyCode.Joystick1Button7))
        {
            if (m_scene.name == "MainMenu")
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
        if (m_scene.name == "MainLevel")
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
