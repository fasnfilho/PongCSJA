using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void irParaSelecaoPlayer()
    {
        SceneManager.LoadScene(1);
    }

    public void selecionarLocalPVP()
    {
        GameSettings.isAgainstAI = false;
        SceneManager.LoadScene(3);
    }

    public void irParaSelecaoDificuldade()
    {
        GameSettings.isAgainstAI = true;
        SceneManager.LoadScene(2);
    }

    public void selecionarDificuldadeFacil()
    {
        GameSettings.aiSpeed = 4f;
        SceneManager.LoadScene(3);
    }

    public void selecionarDificuldadeDificil()
    {
        GameSettings.aiSpeed = 8f;
        SceneManager.LoadScene(3);
    }

}