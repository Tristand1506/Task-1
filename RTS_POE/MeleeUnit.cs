using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTS_POE
{
    class MeleeUnit : Unit
    {

        public MeleeUnit(int xPos, int yPos, int health, int speed, int attack, int attackRange, int team, string symbol, bool isAttacking) : base(xPos, yPos, 110, 1, attack, 1, team, "O", false)
        {
            HEALTH_MAX = health;
            this.xPos = xPos;
            this.yPos = yPos;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.team = team;
            this.symbol = symbol;
            this.isAttacking = isAttacking;
        }

        public int XPos 
        {   get{ return this.xPos; }  set{ xPos = value; }   }

        public int YPos
        { get { return this.yPos; } set { yPos = value; } }

        public int Health
        {
            get { return this.health; }

            /* set {
                 if (value < 0)
                 {
                     health = 0;
                 }
                 else { health = value; }
             }  */
        }

        public int Speed
        {
            get { return this.speed; }

           /* set
            {
                if (value < 0)
                {
                    speed = 0;
                }
                else { speed = value; }
            } */
        }

        public int Attack
        {
            get { return this.attack; }

            set
            {
                if (value < 1)
                {
                    attack = 1;
                }
                else { attack = value; }
            }
        }

        public int AttackRange
        {
            get { return this.attackRange; }

           /* set
            {
                if (value < 1)
                {
                    attackRange = 1;
                }
                else { attackRange = value; }
            } */
        }

        public int Team
        {
            get { return team; }
        }

        public string Symbol
        {
            get { return this.symbol; }

            /* set
            {
                if ((value.Trim()).Equals(""))
                {
                    symbol = "O";
                }
                else if (value.Length > 1)
                {
                    symbol = value[0] + "";
                }
                else { symbol = value; }
                
            } */
        }

        public bool IsAttacking
        {
            get { return this.isAttacking; }

            set { isAttacking = value; }
        }

        public int HealthMax
        {
            get { return this.HEALTH_MAX; }
        }






        public override void move()
        {
            /*if (true)
            {

            }
           */


        }

        public override void combat()
        {
            throw new NotImplementedException();
            //explosions go here
        }
        public override bool inRange(int[] xy)
        {

            int enemyX = xy[0];
            int enemyY = xy[1];
            double distance= Math.Sqrt(Math.Pow(Math.Abs( enemyX- this.XPos), 2) + Math.Pow(Math.Abs(enemyY - this.YPos), 2));
            if ( distance <= AttackRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int[] nearby(Unit[] units)
        {
            int closestUnit = 0;
            double closeestDistance = Int32.MaxValue;
            for (int j = 0; j < units.Length; j++)
            {
                if (units[j].Team != this.Team)
                {
                    double distance = Math.Sqrt(Math.Pow(Math.Abs(units[j].XPos - this.XPos), 2) + Math.Pow(Math.Abs(units[j].YPos - this.YPos), 2));

                    if (distance < closeestDistance)
                    {
                        closestUnit = j;
                    }
                }
            }
            int[] xy = { units[closestUnit].XPos, units[closestUnit].YPos };
            return xy;
        }
        
        

        public override void death()
        {

        }

        public override string ToString()
        {
            return Symbol + ": (" + XPos + ","+ YPos + ") HP: " + Health + "Attack: " + Attack;

            throw new NotImplementedException();
        }
    }
}
