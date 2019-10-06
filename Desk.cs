using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Coates
{
    class Desk
    {
        public double Width { get; set; }
        public double Depth{ get; set; }

        private int numDrawers1;

        public int GetnumDrawers()
        {
            return numDrawers1;
        }

        public void SetnumDrawers(int value)
        {
            numDrawers1 = value;
        }
    }

    enum surfMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Veneer = 125

    };
}
