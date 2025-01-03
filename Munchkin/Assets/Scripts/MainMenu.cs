using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    [SerializeField] private Button Button;
    //[SerializeField] private Button Quit;

    private void Awake()
    {
        Button.onClick.AddListener(Jogar);
        // Quit.onClick.AddListener(SairJogo);
    }

    private void Jogar()
    {
        Debug.Log("PLAY");
        //SceneManager.LoadScene();
    }

    public void SairJogo()
    {
        Application.Quit();
        Debug.Log("Sair do jogo");
    }
}
