using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    class RPGChar
    {

        protected string name;
        protected int strength;
        protected int dexterity;
        protected int intelligence;
        protected int xp;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        public int Dexterity
        {
            get { return dexterity; }
            set { dexterity = value; }
        }
        public int Intelligence
        {
            get { return intelligence; }
            set { intelligence = value; }
        }
        public int Xp
        {
            get { return xp; }
            set { xp = value; }
        }





        //constructors
        public RPGChar() : this("John", 11, 11, 11) { }
        public RPGChar(string n, int s, int d, int i)
        {
            name = n;
            strength = s;
            dexterity = d;
            intelligence = i;
            xp = 0;
        }

        public override string ToString()
        {
            return (name + " has " + strength + " points of strength, " + dexterity + " points of dexterity, " + intelligence + " points of intelligence, " + xp + " points of experience and");
        }

        public void GainXP(int exp)
        {
            xp = xp + exp;
        }





    }
}
