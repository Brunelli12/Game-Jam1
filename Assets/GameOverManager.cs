using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel; 

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true); 
        Time.timeScale = 0f;           
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1f;           
        SceneManager.LoadScene("Menu 1"); 
    }
}
