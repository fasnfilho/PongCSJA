using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void irParaSelecaoPlayer()
    {
        SceneManager.LoadScene(1);
    }

    public void irParaSelecaoDificuldade()
    {
        SceneManager.LoadScene(2);
    }

    public void irParaPartida()
    {
        SceneManager.LoadScene(3);
    }
}