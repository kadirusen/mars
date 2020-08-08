using NUnit.Framework;
using System;
using mars.Core.Models;
using mars.Core.Helpers;
using System.Collections.Generic;

namespace mars.Test
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void Test_12N_LMLMLMLM()
        {
            Position position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var maxValues = new List<int>() { 5, 5 };
            var actions = "LMLMLMLM";

            position.Move(maxValues, actions);

            var realOut = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var validOut = "1 2 N";

            Assert.AreEqual(validOut, realOut);
        }

        [Test()]
        public void Test_12N_LMLMLMLMM()
        {
            Position position = new Position()
            {
                X = 1,
                Y = 2,
                Direction = Directions.N
            };

            var maxValues = new List<int>() { 5, 5 };
            var actions = "LMLMLMLMM";

            position.Move(maxValues, actions);

            var realOut = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var validOut = "1 3 N";

            Assert.AreEqual(validOut, realOut);
        }

        [Test()]
        public void Test_33E_MMRMMRMRRM()
        {
            Position position = new Position()
            {
                X = 3,
                Y = 3,
                Direction = Directions.E
            };

            var maxValues = new List<int>() { 5, 5 };
            var actions = "MMRMMRMRRM";

            position.Move(maxValues, actions);

            var realOut = $"{position.X} {position.Y} {position.Direction.ToString()}";
            var validOut = "5 1 E";

            Assert.AreEqual(validOut, realOut);
        }
    }
}
