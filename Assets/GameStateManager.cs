using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public GameObject telaGameOver;
    public GameObject telaVitoria;

    public void GameOver()
    {
        Time.timeScale = 0f; // pausa o jogo
        telaGameOver.SetActive(true);
    }

    public void Vitoria()
    {
        Time.timeScale = 0f; // pausa o jogo
        telaVitoria.SetActive(true);
    }

    public void Reiniciar()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void VoltarMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene"); // Altere para o nome da sua cena de menu
    }
}
