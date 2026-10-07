using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Win()
    {
        SceneManager.LoadSceneAsync(2); // Load Win Screen
    }
}
