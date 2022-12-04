using Year2022.Day2.Model;

namespace Year2022.Day2;

public class Part2
{
    public static int Calculate(Move[] moves)
    {
        var points = 0;
        foreach (var move in moves)
        {
            switch (move.RoundEnd)
            {
                case RoundEnd.Draw:
                    points += 3;
                    break;
                case RoundEnd.Lose:
                    points += 0;
                    break;
                case RoundEnd.Win:
                    points += 6;
                    break;
            }
            switch (move.OpponentMove)
            {
                case OpponentMove.Rock:
                    switch (move.RoundEnd)
                    {
                        case RoundEnd.Draw:
                            move.OwnMove = OwnMove.Rock;
                            break;
                        case RoundEnd.Lose:
                            move.OwnMove = OwnMove.Scissors;
                            break;
                        case RoundEnd.Win:
                            move.OwnMove = OwnMove.Paper;
                            break;
                    }

                    break;
                case OpponentMove.Paper:
                    switch (move.RoundEnd)
                    {
                        case RoundEnd.Draw:
                            move.OwnMove = OwnMove.Paper;
                            break;
                        case RoundEnd.Lose:
                            move.OwnMove = OwnMove.Rock;
                            break;
                        case RoundEnd.Win:
                            move.OwnMove = OwnMove.Scissors;
                            break;
                    }
                    break;
                case OpponentMove.Scissors:
                    switch (move.RoundEnd)
                    {
                        case RoundEnd.Draw:
                            move.OwnMove = OwnMove.Scissors;
                            break;
                        case RoundEnd.Lose:
                            move.OwnMove = OwnMove.Paper;
                            break;
                        case RoundEnd.Win:
                            move.OwnMove = OwnMove.Rock;
                            break;
                    }
                    break;
                default:
                    break;
            }
            points += CalculateMovePoints(move.OwnMove);
        }
        return points;
    }

    private static int CalculateMovePoints(OwnMove ownMove)
    {
        return ownMove switch
        {
            OwnMove.Rock => 1,
            OwnMove.Paper => 2,
            OwnMove.Scissors => 3,
            _ => 0,
        };
    }
}
