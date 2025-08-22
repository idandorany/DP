using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int CurrentPlayer { get; private set; } = 1;
    public bool GameOver { get; private set; } = false;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
       
    }

    public void SwitchTurn() => CurrentPlayer = (CurrentPlayer == 1) ? 2 : 1;

    public void EndGame(int winner)
    {
        GameOver = true;
        Debug.Log($"Player {winner} wins!");
    }

    public void ResetGame()
    {
        CurrentPlayer = 1;
        GameOver = false;
    }
}
