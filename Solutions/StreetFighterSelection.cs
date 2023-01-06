using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class StreetFighterSelection
    {
        public static string[] Solution(string[][] fighters, int[] position, string[] moves)
        {
            List<string> fighterVisited = new List<string>();

            var (y, x) = (position[0], position[1]);

            foreach(var move in moves)
            {
                switch(move)
                {
                    case "up":
                        if (y - 1 < 0)
                        {
                            y = 0;
                            break;
                        }

                        y -= 1;

                        break;

                    case "down":
                        if (y + 1 > fighters.Length - 1)
                        {
                            y = fighters.Length - 1;
                            break;
                        }

                        y += 1;

                        break;

                    case "right":
                        if (x + 1 > fighters[0].Length - 1)
                        {
                            x = 0;
                            break;
                        }

                        x += 1;

                        break;

                    case "left":
                        if (x - 1 < 0)
                        {
                            x = fighters[0].Length - 1;
                            break;
                        }

                        x -= 1;

                        break;

                    default:
                        throw new ArgumentException("Invalid move");
                }

                fighterVisited.Add(fighters[y][x]);
            }

            return fighterVisited.ToArray();
        }
    }
}
