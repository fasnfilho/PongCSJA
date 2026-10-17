using DG.Tweening;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameManager gameManager;
    private SpriteRenderer wallSprite;
    private Color originalColor;

    void Start()
    {
        if (gameManager == null)
        {
            gameManager = Object.FindAnyObjectByType<GameManager>();
        }

        wallSprite = GetComponent<SpriteRenderer>();
        if (wallSprite != null)
        {
            originalColor = wallSprite.color;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {

            if(wallSprite != null && !CompareTag("AIWall") && !CompareTag("PlayerWall"))
            {
                wallSprite.transform.DOKill();
                wallSprite.color = Color.white;
                wallSprite.DOColor(originalColor, 0.25f);
            }

            if (CompareTag("AIWall"))
            {
                gameManager.PlayerPoint();
            }

            if(CompareTag("PlayerWall"))
            {
                gameManager.AIPoint();
            }

            other.gameObject.GetComponent<Ball>().ResetBall();
        }
    }
}
