using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenScript : MonoBehaviour
{
    public void StartButton(string sceneName)
    {
        Debug.Log("Started the game!");
        SceneManager.LoadScene(sceneName);
    }

    public void QuitButton()
    {
        Debug.Log("Application Quit!");
        Application.Quit();
    }
}
