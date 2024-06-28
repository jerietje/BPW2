using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour 
{
    //Scene 0 = menu, Scene 1 = game

    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

/*    public void OptionGame()
    {
       SceneManager.LoadScene(3); //This loads scene 3 the options menu
    }*/

    public void BackGame()
    {
       SceneManager.LoadScene(0); 
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}