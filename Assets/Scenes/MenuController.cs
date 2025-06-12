using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject MenuPrincipal;      
    public GameObject ComoJogarPanel;    

    public void Jogar()
    {
        SceneManager.LoadScene("Game 1"); 
    }

    public void MostrarComoJogar()
    {
        MenuPrincipal.SetActive(false); 
        ComoJogarPanel.SetActive(true);
    }

    public void FecharComoJogar()
    {
        ComoJogarPanel.SetActive(false);
        MenuPrincipal.SetActive(true); 
    }
}
