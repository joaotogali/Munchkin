using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipalManager : MonoBehaviour
{

    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject MenuPrincipal;
    //[SerializeField] private Button Quit;

    public void Jogadores1()
    {
        Debug.Log("PLAY 1 JOGADOR");
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void Jogadores2 ()
    {
        Debug.Log("PLAY 2 JOGADORES");
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void Jogadores3 ()
    {
        Debug.Log("PLAY 3 JOGADORES");
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void Jogadores4 ()
    {
        Debug.Log("PLAY 4 JOGADORES");
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void SairJogo ()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
        
}