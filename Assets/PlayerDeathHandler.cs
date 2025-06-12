using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeathHandler : MonoBehaviour
{
    public GameObject gameOverPanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Espinho")) 
        {
            Die();
        }
    }

    void Die()
    {
        Time.timeScale = 0f; 
        gameOverPanel.SetActive(true); 
    }

    public void VoltarParaMenu()
    {
        Time.timeScale = 1f; 
        SceneManager.LoadScene("Menu 1"); 
    }
}
