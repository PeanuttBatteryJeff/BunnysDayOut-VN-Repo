using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Loads scene called "GameScene"
        SceneManager.LoadScene("GameScene");
        Debug.Log("Loading GameScene...");
    }

    public void QuitGame()
    {
        //Forces application to shut down
        Application.Quit();
        Debug.Log("Exiting application...");
    }
}
