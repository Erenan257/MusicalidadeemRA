using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NoteGameManager : MonoBehaviour
{
    public string notaCorreta;
    public int pontuacao = 0;

    public TMP_Text pontuacaoText;   // UI da pontuação
    public TMP_Text mensagemText;    // UI da mensagem

    public void NotaTocada(GameObject nota)
    {
        string nome = nota.name.ToLower();

        if (nome == notaCorreta.ToLower())
        {
            pontuacao++;
            if (mensagemText != null)
                mensagemText.text = "Correto!";
        }
        else
        {
            if (mensagemText != null)
                mensagemText.text = "Errado!";
        }

        if (pontuacaoText != null)
            pontuacaoText.text = "Pontuação: " + pontuacao;
    }
}
