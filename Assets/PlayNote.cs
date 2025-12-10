using UnityEngine;

public class PlayNote : MonoBehaviour
{
    public AudioSource audioSource;
    private NoteGameManager gameManager;

    void Start()
    {
        gameManager = FindObjectOfType<NoteGameManager>();
    }

    private void OnMouseDown()
    {
        if (audioSource != null)
            audioSource.Play();

        if (gameManager != null)
            gameManager.NotaTocada(gameObject);
    }
}
