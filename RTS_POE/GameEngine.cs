using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_POE
{
    class GameEngine
    {
        int round = 1;

        public Map battleMap = new Map(20);

        public void UpdateUnits(ref Unit[] units)
        {
            for (int i = 0; i < units.Length; i++)
            {
                if (units[i].Health < (units[i].HealthMax)*0.25) 
                {
                    // random move
                }
                else
                {
                    int closestUnit;
                    double closeestDistance = Int32.MaxValue;
                    for (int j = 0; j < units.Length; j++)
                    {
                        if (units[j].Team!=units[i].Team)
                        {
                            double distance = Math.Sqrt(Math.Pow(Math.Abs(units[j].XPos - units[i].XPos), 2) + Math.Pow(Math.Abs(units[j].YPos - units[i].YPos), 2));

                            if (distance<closeestDistance)
                            {
                                closestUnit = j;
                            }      
                        }
                    }
                    if (//unit in range)
                    {

                    }
                    else
                    {
                        //move
                    }
                }
            }
        }
    }
}
