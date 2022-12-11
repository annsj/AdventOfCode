using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022AdvOfCode.Days
{
    public class Day02 : AdventDay
    {
        public Day02(string inputFile) : base(inputFile)
        {
        }

        public int GetAnswerPart1()
        {
            int score = 0;

            foreach (var line in FileContent)
            {
                char[] moves = ParseFileLine(line);
                char theirMove = moves[0];
                char myMove = moves[1];
                score += GetShapeScore(myMove);
                score += GetOutcomscore(theirMove, myMove);
            }

            return score;
        }

        public int GetAnswerPart2()
        {
            int score = 0;

            foreach (var line in FileContent)
            {
                char[] move_strategy = ParseFileLine(line);
                char theirMove = move_strategy[0];
                char myMove = SelectMove(theirMove, move_strategy[1]);
                score += GetShapeScore(myMove);
                score += GetOutcomscore(theirMove, myMove);
            }

            return score;
        }

        public static int GetShapeScore(char shape)
        {
            if (shape > 67)
                return shape - 87;
            else
                return shape - 64;
        }

        public static int GetOutcomscore(char theirMove, char myMove)
        {
            int theirValue = theirMove - 65;
            int myValue = 0;

            // myMove can be either A, B, C or X, Y, Z
            if (myMove > 67)
                myValue = myMove - 88;
            else
                myValue = myMove - 65;

            int diff = (myValue - theirValue + 3) % 3;

            if (diff == 0)
                return 3;
            if (diff == 1)
                return 6;
            else
                return 0;
        }

        public char[] ParseFileLine(string line)
        {
            string[] movesSet = line.Split(" ");
            char[] moves = new char[movesSet.Length];

            for (int i = 0; i < movesSet.Length; i++)
                moves[i] = movesSet[i].ToCharArray()[0];

            return moves;
        }

        public static char SelectMove(char theirMove, char strategy)
        {
            char myMove = 'a';

            if (theirMove == 'A')
            {
                switch (strategy)
                {
                    case 'X':
                        myMove = 'C';
                        break;
                    case 'Y':
                        myMove = 'A';
                        break;
                    case 'Z':
                        myMove = 'B';
                        break;
                    default:
                        break;
                }
            }

            if (theirMove == 'B')
            {
                switch (strategy)
                {
                    case 'X':
                        myMove = 'A';
                        break;
                    case 'Y':
                        myMove = 'B';
                        break;
                    case 'Z':
                        myMove = 'C';
                        break;
                    default:
                        break;
                }
            }

            if (theirMove == 'C')
            {
                switch (strategy)
                {
                    case 'X':
                        myMove = 'B';
                        break;
                    case 'Y':
                        myMove = 'C';
                        break;
                    case 'Z':
                        myMove = 'A';
                        break;
                    default:
                        break;
                }
            }

            return myMove;
        }
    }
}
