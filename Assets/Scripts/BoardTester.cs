using UnityEngine;

public class BoardTester : MonoBehaviour
{
    void Start()
    {
        Board board = new Board();
        board.SetCell(0, 0, 1); 
        board.SetCell(1, 1, 1); 
        board.SetCell(2, 2, 1); 

        int winner = board.CheckWinner();
        Debug.Log("Winner is: Player " + winner);
    }
}
