using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject MenuPrincipal;      // Painel com os bot�es
    public GameObject ComoJogarPanel;    // Painel com instru��es

    public void Jogar()
    {
        SceneManager.LoadScene("GameScene"); // Troque pelo nome da sua cena de jogo
    }

    public void MostrarComoJogar()
    {
        MenuPrincipal.SetActive(false); // Corrigido o nome da vari�vel
        ComoJogarPanel.SetActive(true);
    }

    public void FecharComoJogar()
    {
        ComoJogarPanel.SetActive(false);
        MenuPrincipal.SetActive(true); // Corrigido o nome da vari�vel
    }
}
