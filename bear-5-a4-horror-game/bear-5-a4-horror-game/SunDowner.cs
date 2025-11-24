using System;
using MohawkGame2D;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MohawkGame2D
{
    public class SunDowner
    {
        Camera Camera = new Camera();
        Doors DoorCheck = new Doors();
        OST sunDownerSounds = new OST();
        
        int cameraPosition;
        int sunDownerScreen=4;
        Vector2 sunDownerPosition = new Vector2(300,300);
        float sunDownerMoveTick=0;
        bool isPlayerAlive = true;
        bool hasScared = false;
        bool isStaredAt = false;
        bool powerStatus = true;
        float frames = 0;
        bool doorClosed;
        Texture2D sunDowner = Graphics.LoadTexture("../../../../../Assets/SunDowner.png");
        Texture2D[] sunDownerJumpScare = {
            Graphics.LoadTexture("../../../../../Jumpscares/Sundownerjumpscare/metal-gear-rising-desperado4.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Sundownerjumpscare/metal-gear-rising-desperado6.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Sundownerjumpscare/metal-gear-rising-desperado7.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Sundownerjumpscare/metal-gear-rising-desperado8.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Sundownerjumpscare/metal-gear-rising-desperado9.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Sundownerjumpscare/metal-gear-rising-desperado13.png"),
            
            };
            
        
        public void DrawSunDowner()
        {
            
            // Player can only switch camera while alive
            if (isPlayerAlive == true)
            {
                Camera.CameraButtons();
            }
            // Get Player Position
             cameraPosition = Camera.ShareScreenPosition();
            // Draw Senator if the Player can see them
            
            if (sunDownerScreen == 0)
            {
                isPlayerAlive = false;
                sunDownerSounds.SunDownerVoiceLines(4);
                if (frames < sunDownerJumpScare.Length)
                {
                    Graphics.Draw(sunDownerJumpScare[(int)frames], 100, 100);
                    frames += 0.1f;
                }
                else
                {
                    Graphics.Draw(sunDowner, 300, 100);
                    if (hasScared==false)
                    {
                        sunDownerSounds.RedSunSound();
                    }
                    hasScared = true;
                }
            }
            else if (cameraPosition == sunDownerScreen)
            {
               Graphics.Draw(sunDowner, sunDownerPosition);
                if (isStaredAt==false)
                {
                    sunDownerSounds.SunDownerVoiceLines(Random.Integer(1,8));
                    isStaredAt = true;
                }
            }
            else if (isStaredAt == true)
            {
                isStaredAt = false;
            }

        }
        public void MoveSunDowner()
        {
            powerStatus = DoorCheck.CheckPowerStatus();
            doorClosed = DoorCheck.CheckDoorStatus();
            if (isPlayerAlive==true)
            {
                sunDownerMoveTick += Random.Integer(1, 40)*Time.DeltaTime;
                if (sunDownerMoveTick >= 100)
                {
                    sunDownerMoveTick = 0;
                    if (doorClosed==true && isStaredAt==false)
                    {
                        sunDownerScreen = Random.Integer(1, 6);
                        sunDownerSounds.SunDownerVoiceLines(9);
                    }
                    else if (isStaredAt==false)
                    {
                        sunDownerScreen = Random.Integer(0, 6);
                        sunDownerSounds.SunDownerVoiceLines(9);
                    }     
                }
            }
        }
        public bool HasNotKilledPlayer()
        {
            if (isPlayerAlive == false && hasScared == true)
            {
                return false;
            }
            return true;
        }
    }
}
