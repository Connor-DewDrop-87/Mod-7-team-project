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
        
        Music Cave = Audio.LoadMusic("../../../../../Audio/Cave.wav");
        Music Chill = Audio.LoadMusic("../../../../../Audio/Chill.wav");
        Music Credits = Audio.LoadMusic("../../../../../Audio/credits music.wav");
        //Senator Armstrong Audio Files
        Sound Idiot = Audio.LoadSound("../../../../../Audio/Armstrong/Senator Armstrong - Idiot.wav");
        Sound NanoMachines = Audio.LoadSound("../../../../../Audio/Armstrong/_Senator - Nanomachines, Son.wav");
        Sound SlimJim = Audio.LoadSound("../../../../../Audio/Armstrong/Voicy_Snap into a slim jim.wav");
        Sound ComeOn = Audio.LoadSound("../../../../../Audio/Armstrong/Voicy_Senator Armstrong - Come on!.wav");
        Sound Source = Audio.LoadSound("../../../../../Audio/Armstrong/Voicy_My source.wav");
        Sound Omelette = Audio.LoadSound("../../../../../Audio/Armstrong/Making the mother of all omelettes here Jack.wav");
        Sound AWhoop = Audio.LoadSound("../../../../../Audio/Armstrong/AWhoop.wav");
        Sound DontFuckWithMe = Audio.LoadSound("../../../../../Audio/Armstrong/DontFuckWithMe.wav");
        Sound Freak = Audio.LoadSound("../../../../../Audio/Armstrong/Freak.wav");
        Sound DontGetCocky = Audio.LoadSound("../../../../../Audio/Armstrong/DontGetCocky.wav");
        Sound GreatestFight = Audio.LoadSound("../../../../../Audio/Armstrong/GreatestFightOfMyLife.wav");
        Sound ILikeYouJack = Audio.LoadSound("../../../../../Audio/Armstrong/ILikeYouJack.wav");
        Sound LittleShit = Audio.LoadSound("../../../../../Audio/Armstrong/LittleShit.wav");
        Sound ArmstrongHurt = Audio.LoadSound("../../../../../Audio/ThatOneHurt.wav");
        Sound ArmstrongSearch = Audio.LoadSound("../../../../../Audio/WhereAreYou.wav");
        //Intercom Armstrong Audio
        Sound UncleSam = Audio.LoadSound("../../../../../Audio/UncleSamNeedsToDieJack.wav");
        Sound WrathUSA = Audio.LoadSound("../../../../../Audio/WrathOfTheUSA.wav");
        Sound EnemyOfAmerica = Audio.LoadSound("../../../../../Audio/Armstrong/EnemyofAmerica.wav");
        Sound HideAndSeek = Audio.LoadSound("../../../../../Audio/Armstrong/HideAndSeekLilBitch.wav");
        //Senator Armstrong Sound Effects
        Sound PipeSound = Audio.LoadSound("../../../../../Audio/Armstrong/Metal_Pipe_Impace.wav");
        Sound VineBoom = Audio.LoadSound("../../../../../Audio/vine-boom.wav");
        //Sundown Audio Files
        Music Redsun = Audio.LoadMusic("../../../../../Audio/SunDowner/Redsun.wav");
        Sound EvilLaugh = Audio.LoadSound("../../../../../Audio/SunDowner/EvilAhhhLaugh.wav");
        Sound FeelPain = Audio.LoadSound("../../../../../Audio/SunDowner/FeelingThePain.wav");
        Sound TakeMore = Audio.LoadSound("../../../../../Audio/SunDowner/Gonna take more than that.wav");
        Sound LoveThisShit = Audio.LoadSound("../../../../../Audio/SunDowner/ILoveThisShit.wav");
        Sound IdiotSD = Audio.LoadSound("../../../../../Audio/SunDowner/IdiotSundown.wav");
        Sound Pathetic = Audio.LoadSound("../../../../../Audio/SunDowner/Pathetic.wav");
        Sound ThisIsFun = Audio.LoadSound("../../../../../Audio/SunDowner/ThisIsFun.wav");
        Sound INVINCIBLE = Audio.LoadSound("../../../../../Audio/SunDowner/IMFUCKINGINVINCIBLE.wav");
        
        public void OmeletteSound()
        {
            Audio.Play(Omelette);
        }
        public void DontFuckSound()
        {
            Audio.Play(DontFuckWithMe);
        }
        public void RedSunSound()
        {
            Audio.Play(Redsun);
        }
    }
}
