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
        // Main Music
        Music Cave = Audio.LoadMusic("../../../../../Audio/Music/Cave.wav");
        Music Chill = Audio.LoadMusic("../../../../../Audio/Music/Chill.wav");
        Music Credits = Audio.LoadMusic("../../../../../Audio/Music/creditsmusic.wav");
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
        Sound UncleSam = Audio.LoadSound("../../../../../Audio/Armstrong/UncleSamNeedsToDieJack.wav");
        Sound WrathUSA = Audio.LoadSound("../../../../../Audio/Armstrong/WrathOfTheUSA.wav");
        Sound EnemyOfAmerica = Audio.LoadSound("../../../../../Audio/Armstrong/EnemyofAmerica.wav");
        Sound HideAndSeek = Audio.LoadSound("../../../../../Audio/Armstrong/HideAndSeekLilBitch.wav");
        //Murphy Sound Effects
        Sound PipeSound = Audio.LoadSound("../../../../../Audio/SoundEffects/Metal_Pipe_Impace.wav");
        Sound VineBoom = Audio.LoadSound("../../../../../Audio/SoundEffects/vine-boom.wav");
        Sound Car = Audio.LoadSound("../../../../../Audio//SoundEffects/Scream1.wav");
        Sound Laugh = Audio.LoadSound("../../../../../Audio/SoundEffects/Laugh2.wav");
        Sound Poggle = Audio.LoadSound("../../../../../Audio/SoundEffects/BoomCloud.wav");
        Sound Dingy = Audio.LoadSound("../../../../../Audio/SoundEffects/ding-sound-effect_2.wav");
        // Blue Emoji Sounds
        Sound Cackle = Audio.LoadSound("../../../../../Audio/SoundEffects/blueemojiinoffice.wav");
        Sound DistortedCackle = Audio.LoadSound("../../../../../Audio/SoundEffects/blueemojimove.wav");
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
        // Door SFX
        Sound doorOpen = Audio.LoadSound("../../../../../Audio/SoundEffects/animatronic-in-door.wav");
        Sound doorClosed = Audio.LoadSound("../../../../../Audio/SoundEffects/door-slamming-fnaf-1-sound-effects.wav");
        // Intro audio
        Sound IntroVoice = Audio.LoadSound("../../../../../Audio/Night1PhoneCall.wav");
        bool hasPlayedSound = false;
        

        public void SenatorVoiceLines(int SFX)
        {
            if (SFX == 1)
            {
                Audio.Play(Idiot);
            }
            if (SFX == 2)
            {
                Audio.Play(NanoMachines);
            }
            if (SFX == 3)
            {
                Audio.Play(SlimJim);
            }
            if (SFX == 4)
            {
                Audio.Play(ComeOn);
            }
            if (SFX == 5)
            {
                Audio.Play(Source);
            }
            if (SFX == 6)
            {
                Audio.Play(Omelette);
            }
            if (SFX == 7)
            {
                Audio.Play(AWhoop);
            }
            if (SFX == 8)
            {
                Audio.Play(UncleSam);
            }
            if (SFX == 9)
            {
                Audio.Play(Freak);
            }
            if (SFX == 10)
            {
                Audio.Play(DontGetCocky);
            }
            if (SFX == 11)
            {
                Audio.Play(GreatestFight);
            }
            if (SFX == 12)
            {
                Audio.Play(ILikeYouJack);
            }
            if (SFX == 13)
            {
                Audio.Play(LittleShit);
            }
            if (SFX == 14)
            {
                Audio.Play(ArmstrongHurt);
            }
            if (SFX == 15)
            {
                Audio.Play(ArmstrongSearch);
            }
            if (SFX == 16)
            {
                Audio.Play(WrathUSA);
            }
            if (SFX == 17)
            {
                Audio.Play(EnemyOfAmerica);
            }
            if (SFX == 18)
            {
                Audio.Play(HideAndSeek);
            }
        }
        public void SunDownerVoiceLines(int SFX)
        {
            if (SFX == 1)
            {
                Audio.Play(EvilLaugh);
            }
            if (SFX == 2)
            {
                Audio.Play(FeelPain);
            }
            if (SFX == 3)
            {
                Audio.Play(TakeMore);
            }
            if (SFX == 4)
            {
                Audio.Play(LoveThisShit);
            }
            if (SFX == 5)
            {
                Audio.Play(IdiotSD);
            }
            if (SFX == 6)
            {
                Audio.Play(Pathetic);
            }
            if (SFX == 7)
            {
                Audio.Play(AWhoop);
            }
            if (SFX == 8)
            {
                Audio.Play(ThisIsFun);
            }
            if (SFX == 9)
            {
                Audio.Play(INVINCIBLE);
            }
        }
        public void MurphyVoiceLines(int SFX)
        {
            if (SFX == 1)
            {
                Audio.Play(PipeSound);
            }
            if (SFX == 2)
            {
                Audio.Play(VineBoom);
            }
            if (SFX == 3)
            {
                Audio.Play(Car);
            }
            if (SFX == 4)
            {
                Audio.Play(Laugh);
            }
            if (SFX == 5)
            {
                Audio.Play(Poggle);
            }
            if (SFX == 6)
            {
                Audio.Play(Dingy);
            }
        }
        public void EmojiSounds(int SFX)
        {
            if (SFX == 1)
            {
                Audio.Play(Cackle);
            }
            if (SFX == 2)
            {
                Audio.Play(DistortedCackle);
            }
        }
        public void DoorSlam(int SFX)
        {
            if (SFX == 1)
            {
                Audio.Play(doorOpen);
            }
            if (SFX == 2)
            {
                Audio.Play(doorClosed);
            }
        }
        public void BackgroundMusic(int SFX)
        {
            if (SFX == 1)
            {
                Audio.Play(Chill);
            }
            if (SFX == 2)
            {
                Audio.Play(Cave);
            }
            if (SFX == 3)
            {
                Audio.Play(Credits);
            }
            // Stop Chill from over lapping with Cave and Credits
            if (Audio.IsPlaying(Cave) || Audio.IsPlaying(Credits))
            {
                Audio.Stop(Chill);
            }
            // Stop Cave from over lapping with Credits
            if (Audio.IsPlaying(Credits))
            {
                Audio.Stop(Cave);
            }
        }
        public void DontFuckSound()
        {
            Audio.Play(DontFuckWithMe);
        }
        public void RedSunSound()
        {
            Audio.Play(Redsun);
        }

        public bool OpeningScene()
        {
            if (hasPlayedSound == false)
            {
                Audio.Play(IntroVoice);
                hasPlayedSound = true;
            }
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                Audio.Stop(IntroVoice);
                hasPlayedSound = true;
            }
            if (Audio.IsPlaying(IntroVoice) == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
