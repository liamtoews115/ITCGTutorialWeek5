using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Win()
    {
        SceneManager.LoadSceneAsync(1); // Load Win Screen
    }
}
