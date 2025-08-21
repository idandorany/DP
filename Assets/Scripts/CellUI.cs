using UnityEngine;
using UnityEngine.UI;

public class CellUI : MonoBehaviour
{
    public int x, y; 
    public Text cellText; 

    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (GameManager.Instance.GameOver) return;

        
        if (TicTacToeController.Instance.MakeMove(x, y, GameManager.Instance.CurrentPlayer))
        {
            
            cellText.text = (GameManager.Instance.CurrentPlayer == 1) ? "X" : "O";

           
            GameManager.Instance.SwitchTurn();
        }
    }

    public void ResetCell()
    {
        cellText.text = "";
    }
}
