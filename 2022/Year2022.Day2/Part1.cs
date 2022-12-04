using Year2022.Day2.Model;

namespace Year2022.Day2;

public static class Part1
{
    public static int Calculate(Move[] moves)
    {
        var points = 0;
        foreach (var move in moves)
        {
            points += CalculateMovePoints(move);
            switch (move.OpponentMove)
            {
                case OpponentMove.Rock:
                    switch (move.OwnMove)
                    {
                        case OwnMove.Rock:
                            points += 3;
                            break;
                        case OwnMove.Paper:
                            points += 6;
                            break;
                        case OwnMove.Scissors:
                            points += 0;
                            break;
                        default:
                            break;
                    }

                    break;
                case OpponentMove.Paper:
                    switch (move.OwnMove)
                    {
                        case OwnMove.Rock:
                            points += 0;
                            break;
                        case OwnMove.Paper:
                            points += 3;
                            break;
                        case OwnMove.Scissors:
                            points += 6;
                            break;
                        default:
                            break;
                    }
                    break;
                case OpponentMove.Scissors:
                    switch (move.OwnMove)
                    {
                        case OwnMove.Rock:
                            points += 6;
                            break;
                        case OwnMove.Paper:
                            points += 0;
                            break;
                        case OwnMove.Scissors:
                            points += 3;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        return points;
    }

    private static int CalculateMovePoints(Move move)
    {
        return move.OwnMove switch
        {
            OwnMove.Rock => 1,
            OwnMove.Paper => 2,
            OwnMove.Scissors => 3,
            _ => 0,
        };
    }
}