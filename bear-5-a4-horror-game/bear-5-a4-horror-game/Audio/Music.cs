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

        // Place your variables here:
        Music FF01 = Audio.LoadMusic("../../../../../Audio/(Audio/First_Fantasy_OST 0.1.wav"); 
        Music Cave = Audio.LoadMusic("../../../../../Audio/(Audio/Cave.wav"); 
        Music Chill = Audio.LoadMusic("../../../../../Audio/(Audio/Chill.wav"); 
        Music Credits = Audio.LoadMusic("../../../../../Audio/(Audio/credits music.wav"); 
        Music Redsun = Audio.LoadMusic("../../../../../Audio/(Audio//Armstrong/Redsun.wav"); 
        Music Idiot = Audio.LoadMusic("../../../../../Audio/(Audio/Armstrong/Senator Armstrong - Idiot.wav"); 
        Music NanoMachines = Audio.LoadMusic("../../../../../Audio/(Audio/Armstrong/_Senator - Nanomachines, Son.wav"); 
        Music SlimJim = Audio.LoadMusic("../../../../../Audio/(Audio/Armstrong/Voicy_Snap into a slim jim.wav"); 
        Music ComeOn = Audio.LoadMusic("../../../../../Audio/(Audio/Armstrong/Voicy_Senator Armstrong - Come on!.wav"); 
        Music Source = Audio.LoadMusic("../../../../../Audio/(Audio/Armstrong/Voicy_My source.wav"); 
        Music Omelette = Audio.LoadMusic("../../../../../Audio/(Audio/Armstrong/Making the mother of all omelettes here Jack.wav"); 
        Music PipeSound = Audio.LoadMusic("../../../../../Audio/(Audio/Armstrong/Metal_Pipe_Impace.wav"); 
        Music VineBoom = Audio.LoadMusic("../../../../../Audio/(Audio/vine-boom.wav"); 
      
     
        public void BackgroundMusic()
        {
            if (!Audio.IsPlaying(FF01))
            {
                Audio.Play(FF01);
            }
            
        }
        public void OmeletteSound()
        {
            Audio.Play(Omelette);
        }
    }
}
