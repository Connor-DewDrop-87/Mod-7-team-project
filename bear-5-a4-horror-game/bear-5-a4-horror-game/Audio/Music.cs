using MohawkGame2D;
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class OST
    {
        public void setup()
        {
            BGM1 = Audio.loadMusic("");
            BGM2 = Audio.loadMusic("");
            BGM3 = Audio.loadMusic("");
            BGM4 = Audio.loadMusic("");
            sfx1 = Audio.loadSouhnd("");
            sfx2 = Audio.loadSound("");
            sfx3 = Audio.loadSound("");
            sfx4 = Audio.loadSound("");

            BGM1.Looping = true;
            BGM2.Looping = true;
        }
        // Place your variables here:
        Music BGM1;
        Music BGM2;
        Music BGM3;
        Music BGM4;
        Music sfx1;
        Music sfx2;
        Music sfx3;
        Music sfx4;
        public void Audio()
        {

        }
    }
}
