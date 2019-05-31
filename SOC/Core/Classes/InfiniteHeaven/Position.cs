using SOC.Classes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SOC.Core.Classes.InfiniteHeaven
{
    public struct Position
    {
        public Coordinates coords { get; set; }

        public Rotation rotation { get; set; }

        public Position(Coordinates c, Rotation r)
        {
            coords = c; rotation = r;
        }
    }

    public class IHLogPositions
    {
        private List<Position> positions;

        public IHLogPositions(string formattedPositions)
        {
            ParsePositions(formattedPositions);
        }

        public IHLogPositions(List<Position> pos)
        {
            positions = pos;
        }

        public void ParsePositions(string formattedPositions)
        {
            positions = new List<Position>();
            string coordPattern = @"-?\d+([.]\d+)?";

            MatchCollection matches = Regex.Matches(formattedPositions, coordPattern);
            var list = matches.Cast<Match>().Select(match => match.Value).ToList();
            while (list.Count % 4 != 0)
            {
                list.Add("0.00");
            }

            for (int i = 0; i < list.Count; i += 4)
            {
                Coordinates coords = new Coordinates(list[i], list[i + 1], list[i + 2]);
                Rotation rot = new Rotation(list[i + 3]);
                positions.Add(new Position(coords, rot));
            }
        }

        public void SetPositions(List<Position> pos)
        {
            positions = pos;
        }

        public List<Position> GetPositions()
        {
            return positions;
        }

        public string GetPositionsFormatted()
        {
            StringBuilder formattedPositions = new StringBuilder("");
            foreach(Position pos in positions)
            {
                formattedPositions.AppendLine($"{{pos={{{pos.coords.xCoord},{pos.coords.yCoord},{pos.coords.zCoord}}},rotY={pos.rotation.GetDegreeRotY()},}},");
            }
            return formattedPositions.ToString();
        }
    }
}
