//This script handles the scene transitions.
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //When the player finishes a level, load the next one.

    }

}
