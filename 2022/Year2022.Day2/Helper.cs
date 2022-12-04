using Year2022.Day2.Model;

namespace Year2022.Day2;

public static class Helper
{
    public static Move[] File2Moves(string input)
    {
        var moves = new List<Move>();
        foreach (var move in File.ReadAllLines(input))
        {
            var splitMove = move.ToCharArray();
            var opponentMove = (OpponentMove)splitMove[0];
            var ownMove = (OwnMove)splitMove[2];
            var roundEnd = (RoundEnd)splitMove[2];
            moves.Add(new Move()
            {
                OpponentMove = opponentMove,
                OwnMove = ownMove,
                RoundEnd = roundEnd
            });
        }
        return moves.ToArray();
    }
}
