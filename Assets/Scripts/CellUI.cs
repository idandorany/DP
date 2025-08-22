using UnityEngine;
using UnityEngine.UI;
using TMPro;   

[RequireComponent(typeof(Button))]
public class CellUI : MonoBehaviour
{
    public int x, y;
    private TMP_Text cellText;   
    private Button button;

    void Awake()
    {
        button = GetComponent<Button>();

        cellText = GetComponentInChildren<TMP_Text>(true);

        if (cellText == null)
            Debug.LogError("[CellUI] No TMP_Text child found under this button!");

        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (GameManager.Instance == null || TicTacToeController.Instance == null) return;
        if (GameManager.Instance.GameOver) return;

        int current = GameManager.Instance.CurrentPlayer;

        if (TicTacToeController.Instance.MakeMove(x, y, current))
        {
            string symbol = (current == 1) ? "X" : "O";
            cellText.text = symbol;

            GameManager.Instance.SwitchTurn();
        }
    }

    public void ResetCell()
    {
        if (cellText != null) cellText.text = string.Empty;
    }
}
