using UnityEngine;

public class CursorController : MonoBehaviour
{
    [Header("Configurações do Cursor")]
    [SerializeField] private Texture2D customCursorTexture;
    [SerializeField] private Vector2 hotSpot = Vector2.zero;
    [SerializeField] private bool hideCursorOnStart = false;

    void Awake()
    {
        if (customCursorTexture != null)
        {
            Cursor.SetCursor(customCursorTexture, hotSpot, CursorMode.Auto);
        }
    }

    void Start()
    {
        if (hideCursorOnStart)
        {
            EsconderCursor();
        }
        else
        {
            ExibirCursor();
        }
    }

    public void EsconderCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
    }

    public void ExibirCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
