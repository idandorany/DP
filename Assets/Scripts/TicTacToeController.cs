using UnityEngine;

public class TicTacToeController : MonoBehaviour
{
    public static TicTacToeController Instance { get; private set; }

    private Board board;

    private void Awake()
    {
        Instance = this;
        board = new Board();
    }

    public bool MakeMove(int x, int y, int player)
    {
        if (board.SetCell(x, y, player))
        {
            int winner = board.CheckWinner();
            if (winner != 0)
            {
                GameManager.Instance.EndGame(winner);
            }
            return true;
        }
        return false;
    }

    public void ResetGame()
    {
        board = new Board();
        GameManager.Instance.ResetGame();
    }
}
