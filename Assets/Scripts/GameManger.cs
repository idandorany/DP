using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int CurrentPlayer { get; private set; } = 1;
    public bool GameOver { get; private set; } = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void SwitchTurn()
    {
        CurrentPlayer = (CurrentPlayer == 1) ? 2 : 1;
        Debug.Log("Now it's Player " + CurrentPlayer + "'s turn");
    }

    public void EndGame(int winner)
    {
        GameOver = true;
        Debug.Log("Player " + winner + " wins!");
    }

    public void ResetGame()
    {
        CurrentPlayer = 1;
        GameOver = false;
    }
}
