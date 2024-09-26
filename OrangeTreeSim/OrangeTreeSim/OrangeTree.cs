using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height;
        private int numOranges;
        private int orangesEaten;
        private bool treeAlive;

        public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public int GetHeight()
        {
            return height;
        }

        public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }

        public bool GetTreeAlive()
        {
            return treeAlive;
        }

        public int GetNumOranges()
        {
            return numOranges;
        }

        public int GetOrangesEaten()
        {
            return orangesEaten;
        }

        public void OneYearPasses()
        {
            age++;
            numOranges = 0;
            
            if (age < 80)
            {
                height = height + 2;

                if (age >= 2)
                {
                    for (int i = 1; i < age; i++)
                    {
                        numOranges = i * 5;
                    }
                }
            }
            else if (age >= 80)
            {
                treeAlive = false;
            }

        }

        public void EatOrange(int count)
        {
            if (count <= numOranges)
            {
                orangesEaten = orangesEaten + count; // tilføjer antallet count til orangesEaten
                
                numOranges = numOranges - count; // fjerner antallet count fra numOranges

            }
        }
    }
}
