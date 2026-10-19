using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerScore;
    public int AIScore;
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI AIScoreText;
    public Image gameOverPanel;
    public TextMeshProUGUI LeftPlayerWin;
    public TextMeshProUGUI RightPlayerWin;

    [Header("Audios")]
    public AudioSource audioSource;
    public AudioClip scoreSFX;

    private bool isGameOver = false;

    [Header("Configurações da Partida")]
    public int maxScoreToWin = 10;

    [Header("Configurações de Raquetes")]
    public GameObject PaddleAIObj;
    public GameObject PaddlePlayer2Obj;

    void Start()
    {
        Time.timeScale = 1f;

        gameOverPanel.gameObject.SetActive(false);

        if (GameSettings.isAgainstAI)
        {
            if (PaddleAIObj != null) PaddleAIObj.SetActive(true);
            if (PaddlePlayer2Obj != null) PaddlePlayer2Obj.SetActive(false);
        }
        else
        {
            if (PaddleAIObj != null) PaddleAIObj.SetActive(false);
            if (PaddlePlayer2Obj != null) PaddlePlayer2Obj.SetActive(true);
        }
    }

    void Update()
    {
        if (isGameOver) return;

        gameOver();
    }

    public void PlayerPoint()
    {
        JuiceText(playerScoreText);

        playerScore++;
        playerScoreText.text = playerScore.ToString();
    }

    public void AIPoint()
    {
        JuiceText(AIScoreText);

        AIScore++;
        AIScoreText.text = AIScore.ToString();
    }

    void JuiceText(TextMeshProUGUI text)
    {
        audioSource.PlayOneShot(scoreSFX);

        text.transform.DOKill();
        text.transform.localScale = Vector3.one;
        text.transform.DOScale(1.5f, 0.5f).SetLoops(2, LoopType.Yoyo).SetUpdate(true);
    }

    void gameOver()
    {
        if (playerScore == maxScoreToWin && Time.timeScale > 0)
        {
            isGameOver = true;

            pausarEMostrarGameOver();

            CursorController cursor = Object.FindAnyObjectByType<CursorController>();
            if (cursor != null)
            {
                cursor.ExibirCursor();
            }

            if (GameSettings.isAgainstAI)
            {
                if (LeftPlayerWin != null) LeftPlayerWin.text = "Você Venceu!";
                if (RightPlayerWin != null) RightPlayerWin.text = "Você Perdeu!";
            }
            else
            {
                if (LeftPlayerWin != null) LeftPlayerWin.text = "Player 1 Venceu!";
                if (RightPlayerWin != null) RightPlayerWin.text = "Player 2 Venceu!";
            }

            LeftPlayerWin.gameObject.SetActive(true);
            RightPlayerWin.gameObject.SetActive(false);


        }
        else if (AIScore == maxScoreToWin && Time.timeScale > 0)
        {
            isGameOver = true;

            pausarEMostrarGameOver();

            CursorController cursor = Object.FindAnyObjectByType<CursorController>();
            if (cursor != null)
            {
                cursor.ExibirCursor();
            }

            if (GameSettings.isAgainstAI)
            {
                if (LeftPlayerWin != null) LeftPlayerWin.text = "Você Venceu!";
                if (RightPlayerWin != null) RightPlayerWin.text = "Você Perdeu!";
            }
            else
            {
                if (LeftPlayerWin != null) LeftPlayerWin.text = "Player 1 Venceu!";
                if (RightPlayerWin != null) RightPlayerWin.text = "Player 2 Venceu!";
            }

            LeftPlayerWin.gameObject.SetActive(false);
            RightPlayerWin.gameObject.SetActive(true);
        }
    }

    void pausarEMostrarGameOver()
    {
        gameOverPanel.gameObject.SetActive(true);

        Time.timeScale = 0f;
    }

    public void restartGame()
    {
        DOTween.KillAll();

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void voltarAoMenu()
    {
        DOTween.KillAll();

        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
