using System;
using System.Linq;
using System.Threading.Tasks;
using mars.Core.Models;

namespace mars
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sınır pozisyon degerleri giriniz: Orn --> 5 5");
            var maxValues = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine("Baslangic degerleri giriniz: Orn --> 2 2 N");

            var firstPositions = Console.ReadLine().Trim().Split(' ');
            Position position = new Position();

            if (firstPositions?.Count() == 3)
            {
                position.X = Convert.ToInt32(firstPositions.FirstOrDefault());
                position.Y = Convert.ToInt32(firstPositions[1]);
                position.Direction = (Directions)Enum.Parse(typeof(Directions), firstPositions.LastOrDefault());
            }

            Console.WriteLine("Hareket degerlerini giriniz: Orn --> LMLMLMLMLM");

            var moves = Console.ReadLine().ToUpper();

            try
            {
                position.Move(maxValues, moves);
                Console.WriteLine($"{position.X} {position.Y} {position.Direction.ToString()}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
