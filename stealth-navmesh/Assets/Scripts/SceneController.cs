using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update
    public void goToMenu()
    {
        SceneManager.LoadScene("MENU");
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void playGame()
    {
        SceneManager.LoadScene("GAME");
    }

    public void winGame()
    {
        SceneManager.LoadScene("WIN");
    }

    public void loseGame()
    {
        SceneManager.LoadScene("LOSE");
    }
}
