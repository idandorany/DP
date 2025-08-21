public class Board
{
    private int[,] cells = new int[3, 3]; 

    public bool SetCell(int x, int y, int player)
    {
        if (cells[x, y] == 0) 
        {
            cells[x, y] = player;
            return true;
        }
        return false;
    }

    public void ClearCell(int x, int y)
    {
        cells[x, y] = 0;
    }

    public int GetCell(int x, int y)
    {
        return cells[x, y];
    }

    public int CheckWinner()
    {
        for (int i = 0; i < 3; i++)
        {
            if (cells[i, 0] != 0 &&
                cells[i, 0] == cells[i, 1] &&
                cells[i, 1] == cells[i, 2])
                return cells[i, 0];
        }

        for (int i = 0; i < 3; i++)
        {
            if (cells[0, i] != 0 &&
                cells[0, i] == cells[1, i] &&
                cells[1, i] == cells[2, i])
                return cells[0, i];
        }

        if (cells[0, 0] != 0 &&
            cells[0, 0] == cells[1, 1] &&
            cells[1, 1] == cells[2, 2])
            return cells[0, 0];

        if (cells[2, 0] != 0 &&
            cells[2, 0] == cells[1, 1] &&
            cells[1, 1] == cells[0, 2])
            return cells[2, 0];

        return 0; 
    }
}
