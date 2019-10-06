using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_POE
{
    class Map
    {
        public Unit[] units;

        public string[,] grid = new string[20, 20];

        Random rnd = new Random();



        public Map(int startingUnits)
        {
            units = new Unit[startingUnits];

            unitGen(units.Length);

            mapUpdate();
        }

        public void unitGen(int numUnits)
        {
            // loops to crete new units
            for (int i = 0; i < numUnits; i++)
            {

                // assigns random x and y values 
                int newX = rnd.Next(0, 20);
                int newY = rnd.Next(0, 20);
                int team = i % 2;
                int tempAttack = 0;

                // randomly assigns units damage values
                switch (rnd.Next(0, 4))
                {
                    case 0: tempAttack = 5; break;
                    case 1: tempAttack = 10; break;
                    case 2: tempAttack = 15; break;
                    case 3: tempAttack = 20; break;
                }

                // randomly gives unit type
                switch (rnd.Next(0, 2))
                {
                    case 0: units[i] = new MeleeUnit(newX, newY, 100, 1, tempAttack, 1, team, "O", false); break;
                    case 1: units[i] = new RangeUnit(newX, newY, 70, 2, tempAttack, 4, team, "U", false); break;

                }
            }
        }

        public void mapUpdate()
        {
            // sets nueral values for the map array
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    grid[i,j] = " • ";
                }
                
            }

            //places units
            for (int i = 0; i < units.Length; i++)
            {
                grid[units[i].XPos, units[i].YPos] = Convert.ToString(units[i].Symbol);
            }
        }
    }
}
