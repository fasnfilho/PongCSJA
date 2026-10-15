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

    void Start()
    {
        Time.timeScale = 1f;

        gameOverPanel.gameObject.SetActive(false);
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
        if (playerScore == 2 && Time.timeScale > 0)
        {
            isGameOver = true;

            pausarEMostrarGameOver();
            LeftPlayerWin.gameObject.SetActive(true);
            RightPlayerWin.gameObject.SetActive(false);


        }
        else if (AIScore == 2 && Time.timeScale > 0)
        {
            isGameOver = true;

            pausarEMostrarGameOver();
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
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
