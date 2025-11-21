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
        Music FF01 = Audio.LoadMusic("../../../../../Audio/First_Fantasy_OST 0.1.wav"); 
        Music Cave = Audio.LoadMusic("../../../../../Audio/Cave.wav"); 
        Music Chill = Audio.LoadMusic("../../../../../Audio/Chill.wav"); 
        Music Credits = Audio.LoadMusic("../../../../../Audio/credits music.wav");
        //Senator Armstrong Audio Files
        Music Idiot = Audio.LoadMusic("../../../../../Audio/Armstrong/Senator Armstrong - Idiot.wav"); 
        Music NanoMachines = Audio.LoadMusic("../../../../../Audio/Armstrong/_Senator - Nanomachines, Son.wav"); 
        Music SlimJim = Audio.LoadMusic("../../../../../Audio/Armstrong/Voicy_Snap into a slim jim.wav"); 
        Music ComeOn = Audio.LoadMusic("../../../../../Audio/Armstrong/Voicy_Senator Armstrong - Come on!.wav"); 
        Music Source = Audio.LoadMusic("../../../../../Audio/Armstrong/Voicy_My source.wav"); 
        Music Omelette = Audio.LoadMusic("../../../../../Audio/Armstrong/Making the mother of all omelettes here Jack.wav");
        Music AWhoop = Audio.LoadMusic("../../../../../Audio/Armstrong/AWhoop.wav");
        Music DontFuckWithMe = Audio.LoadMusic("../../../../../Audio/Armstrong/DontFuckWithMe.wav");
        Music Freak = Audio.LoadMusic("../../../../../Audio/Armstrong/Freak.wav");
        Music DontGetCocky = Audio.LoadMusic("../../../../../Audio/Armstrong/DontGetCocky.wav");
        Music GreatestFight = Audio.LoadMusic("../../../../../Audio/Armstrong/GreatestFightOfMyLife.wav");
        Music ILikeYouJack = Audio.LoadMusic("../../../../../Audio/Armstrong/ILikeYouJack.wav");
        Music LittleShit = Audio.LoadMusic("../../../../../Audio/Armstrong/LittleShit.wav");
        Music ArmstrongHurt = Audio.LoadMusic("../../../../../Audio/ThatOneHurt.wav");
        Music ArmstrongSearch = Audio.LoadMusic("../../../../../Audio/WhereAreYou.wav");
        //Intercom Armstrong Audio
        Music UncleSam = Audio.LoadMusic("../../../../../Audio/UncleSamNeedsToDieJack.wav");
        Music WrathUSA = Audio.LoadMusic("../../../../../Audio/WrathOfTheUSA.wav");
        Music EnemyOfAmerica = Audio.LoadMusic("../../../../../Audio/Armstrong/EnemyofAmerica.wav");
        Music HideAndSeek = Audio.LoadMusic("../../../../../Audio/Armstrong/HideAndSeekLilBitch.wav");
        //Senator Armstrong Sound Effects
        Music PipeSound = Audio.LoadMusic("../../../../../Audio/Armstrong/Metal_Pipe_Impace.wav"); 
        Music VineBoom = Audio.LoadMusic("../../../../../Audio/vine-boom.wav");
        //Sundown Audio Files
        Music Redsun = Audio.LoadMusic("../../../../../Audio/SunDowner/Redsun.wav");
        Music EvilLaugh = Audio.LoadMusic("../../../../../Audio/SunDowner/EvilAhhhLaugh.wav");
        Music FeelPain = Audio.LoadMusic("../../../../../Audio/SunDowner/FeelingThePain.wav");
        Music TakeMore = Audio.LoadMusic("../../../../../Audio/SunDowner/Gonna take more than that.wav");
        Music LoveThisShit = Audio.LoadMusic("../../../../../Audio/SunDowner/ILoveThisShit.wav");
        Music IdiotSD = Audio.LoadMusic("../../../../../Audio/SunDowner/IdiotSundown.wav");
        Music Pathetic = Audio.LoadMusic("../../../../../Audio/SunDowner/Pathetic.wav");
        Music ThisIsFun = Audio.LoadMusic("../../../../../Audio/SunDowner/ThisIsFun.wav");
        Music INVINCIBLE = Audio.LoadMusic("../../../../../Audio/SunDowner/IMFUCKINGINVINCIBLE.wav");

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
