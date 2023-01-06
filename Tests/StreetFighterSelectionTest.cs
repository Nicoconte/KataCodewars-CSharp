using Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class StreetFighterSelectionTest
    {
        private string[][] _fightersGrid;

        public StreetFighterSelectionTest()
        {
            _fightersGrid = new string[][]
            {
                new string[] { "Ryu", "E.Honda", "Blanka", "Guile", "Balrog", "Vega" },
                new string[] { "Ken", "Chun Li", "Zangief", "Dhalsim", "Sagat", "M.Bison" },
            };

        }

        [Fact]
        public void Test_ShouldReturnExpectedFighters()
        {
            var moves = new string[] { "up", "left", "right", "left", "left" };
            var expected = new string[] { "Ryu", "Vega", "Ryu", "Vega", "Balrog" };

            var response = StreetFighterSelection.Solution(_fightersGrid, new int[] { 0, 0 }, moves);

            Assert.Equal(expected, response);
        }

        [Fact]        
        public void Test_ShouldWorkWhenAlwaysMovingLeft()
        {
            var moves = new string[] { "left", "left", "left", "left", "left", "left", "left", "left" };
            var expected = new string[] { "Vega", "Balrog", "Guile", "Blanka", "E.Honda", "Ryu", "Vega", "Balrog" };

            Assert.Equal(expected, StreetFighterSelection.Solution(_fightersGrid, new int[] { 0, 0 }, moves));
        }

        [Fact]
        public void Test_ShouldUseAll4DirectionsClockwiseTwice()
        {
            var moves = new string[] { "up", "left", "down", "right", "up", "left", "down", "right" };
            var expected = new string[] { "Ryu", "Vega", "M.Bison", "Ken", "Ryu", "Vega", "M.Bison", "Ken" };

            Assert.Equal(expected, StreetFighterSelection.Solution(_fightersGrid, new int[] { 0, 0 }, moves));
        }
    }
}
