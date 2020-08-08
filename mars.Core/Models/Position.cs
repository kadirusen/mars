using System;
using System.Collections.Generic;
using mars.Core.Interfaces;
using mars.Core.Helpers;

namespace mars.Core.Models
{
    public class Position : IPosition
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions Direction { get; set; }

        public Position()
        {
            X = Y = 0;
            Direction = Directions.N;
        }

        private void RotateRight90()
        {
            this.Direction = MoveHelper.MoveRight90(this.Direction);

        }

        private void RotateLeft90()
        {
            this.Direction = MoveHelper.MoveLeft90(this.Direction);
        }

        private void MoveDirection()
        {
            switch (this.Direction)
            {
                case Directions.N:
                    this.Y += 1;
                    break;
                case Directions.S:
                    this.Y -= 1;
                    break;
                case Directions.E:
                    this.X += 1;
                    break;
                case Directions.W:
                    this.X -= 1;
                    break;
                default:
                    break;
            }
        }

        public void Move(List<int> maxPoints, string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'R':
                        this.RotateRight90();
                        break;
                    case 'L':
                        this.RotateLeft90();
                        break;
                    case 'M':
                        this.MoveDirection();
                        break;
                    default:
                        Console.WriteLine($"Girilen L, R yada M olabilir. Hatalı girilen: {move}");
                        break;
                }

                if (this.X > maxPoints[0] || this.Y > maxPoints[1] || this.X < 0 || this.Y < 0 )
                {
                    throw new Exception($"Sinirin otesine ciktiniz.. (0 , 0) and ({maxPoints[0]} , {maxPoints[1]}) araliginda olmali.");
                }
            }
        }
    }
}
