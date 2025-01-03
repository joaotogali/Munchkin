using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciaCena : MonoBehaviour
{
    public void MudaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}
