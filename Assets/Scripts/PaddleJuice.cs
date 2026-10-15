using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;

public class PaddleJuice : MonoBehaviour
{

    public float bounceForce;
    public Transform paddleSprite;
    public void PlayHitEffect()
    {
        paddleSprite.transform.DOScale(1.5f, 0.1f).SetLoops(2, LoopType.Yoyo);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Rigidbody2D ballRig = other.gameObject.GetComponent<Rigidbody2D>();
            float yOffset = other.transform.position.y - transform.position.y;
            float paddleHeight = GetComponent<Collider2D>().bounds.size.y;
            float normalizedY = yOffset / (paddleHeight / 2f);

            Vector2 direction = new Vector2(Math.Sign(ballRig.linearVelocity.x), normalizedY).normalized;

            ballRig.linearVelocity = direction * bounceForce;
        }
    }
}
