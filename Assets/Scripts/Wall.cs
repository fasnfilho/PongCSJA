using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameManager gameManager;

    void Start()
    {
        if (gameManager == null)
        {
            gameManager = Object.FindAnyObjectByType<GameManager>();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
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
