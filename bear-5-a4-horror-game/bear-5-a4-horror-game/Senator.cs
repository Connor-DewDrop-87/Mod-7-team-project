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
    public class Senator
    {
        Camera Camera = new Camera();
        Doors DoorCheck = new Doors();
        OST senatorSounds = new OST();
        
        int cameraPosition;
        int senatorScreen=3;
        Vector2 senatorPosition = new Vector2(300,200);
        float senatorMoveTick=0;
        bool isPlayerAlive = true;
        bool hasScared = false;
        bool isStaredAt = false;
        bool powerStatus = true;
        int armstrongSprites = 0;
        int maybeShirtless = 0;
        float staredMoveTick = 0;
        float frames = 0;
        bool doorClosed;
        Texture2D[] senator = {
            Graphics.LoadTexture("../../../../../Assets/ArmstrongSprites/thing.png"),
            Graphics.LoadTexture("../../../../../Assets/ArmstrongSprites/shirtless.png"),
                };
        Texture2D[] senatorJumpScare = {
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_00_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_01_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_02_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_03_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_04_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_05_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_06_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_07_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_08_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_09_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_10_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_11_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_12_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_13_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_14_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_15_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_16_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_17_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_18_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_19_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_20_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_21_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_22_delay-0.04s.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Senatorjumpscare/frame_23_delay-0.04s.png"),
            };
            
        
        public void DrawSenator()
        {
            
            // Player can only switch camera while alive
            if (isPlayerAlive == true)
            {
                Camera.CameraButtons();
            }
            // Get Player Position
             cameraPosition = Camera.ShareScreenPosition();
            // Draw Senator if the Player can see them
            
            if (senatorScreen == 0)
            {
                isPlayerAlive = false;
                senatorSounds.RedSunSound();
                if (frames < 24)
                {
                    Graphics.Draw(senatorJumpScare[(int)frames], 100, 100);
                    frames += 0.5f;
                }
                else
                {
                    Graphics.Draw(senator[armstrongSprites], 300, 100);
                    if (hasScared==false)
                    {
                        senatorSounds.DontFuckSound();
                        
                    }
                    hasScared = true;
                }
            }
            else if (cameraPosition == senatorScreen)
            {
               Graphics.Draw(senator[armstrongSprites], senatorPosition);
                if (isStaredAt==false)
                {
                    senatorSounds.SenatorVoiceLines(Random.Integer(1,17));
                    if (Random.Integer(1, 10) == 1)
                    {
                        armstrongSprites = 1;
                    }
                    else
                    {
                        armstrongSprites = 0;
                    }
                    isStaredAt = true;
                    maybeShirtless = Random.Integer(1, 10);
                }
            }
            else if (isStaredAt == true)
            {
                staredMoveTick = 0;
                isStaredAt = false;
            }

        }
        public void MoveSenator()
        {
            powerStatus = DoorCheck.CheckPowerStatus();
            doorClosed = DoorCheck.CheckDoorStatus();
            if (isPlayerAlive==true)
            {
                senatorMoveTick += Random.Integer(10, 30)*Time.DeltaTime;
                if (senatorMoveTick >= 255)
                {
                    senatorMoveTick = 0;
                    if (isStaredAt==false)
                    {
                        if (senatorScreen == 1 || senatorScreen == 6)
                        {
                            senatorScreen = 0;
                        }
                        else
                        {
                            senatorScreen = Random.Integer(senatorScreen - 2, senatorScreen + 2);
                        }
                        senatorSounds.SenatorVoiceLines(18);
                        // Ensures Senator doesn't go out of bounds when under 0
                        if (senatorScreen < 0)
                        {
                            senatorScreen = 6;
                        }
                        // Ensures Senator doesn't go out of bounds when over 6
                        if (senatorScreen > 6)
                        {
                            senatorScreen = 0;
                        }
                        // Ensure Senator Doesn't go through door if closed
                        if (doorClosed==true && senatorScreen == 0)
                        {
                            senatorScreen += Random.Integer(2,3);
                        }
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
