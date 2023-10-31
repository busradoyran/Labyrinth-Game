using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
    public void PlayAgain()
    {
        Debug.Log("LET'S PLAY AGAIN!");
        SceneManager.LoadScene(0);
    }
}
