using System;
using mars.Core.Models;
namespace mars.Core.Helpers
{
    public static class MoveHelper
    {
        public static Directions MoveRight90(Directions direction)
        {
            var result = Directions.N;
            switch (direction)
            {
                case Directions.N:
                    result = Directions.E;
                     break;
                case Directions.S:
                    result = Directions.W;
                    break;
                case Directions.E:
                    result = Directions.S;
                    break;
                case Directions.W:
                    result = Directions.N;
                    break;
            }

            return result;
        }

        public static Directions MoveLeft90(Directions direction)
        {
            var result = Directions.N;
            switch (direction)
            {
                case Directions.N:
                    result = Directions.W;
                    break;
                case Directions.S:
                    result = Directions.E;
                    break;
                case Directions.E:
                    result = Directions.N;
                    break;
                case Directions.W:
                    result = Directions.S;
                    break;
            }

            return result;
        }
    }
}
