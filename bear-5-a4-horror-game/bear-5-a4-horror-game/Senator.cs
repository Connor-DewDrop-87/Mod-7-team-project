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
        float frames = 0;
        bool doorClosed;
        Texture2D senator = Graphics.LoadTexture("../../../../../Assets/thing.png");
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
            Text.Draw($"{senatorMoveTick}", new Vector2(0, 0));
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
                    Graphics.Draw(senator, 300, 100);
                    hasScared = true;
                }
            }
            else if (cameraPosition == senatorScreen)
            {
               Graphics.Draw(senator, senatorPosition);
                if (isStaredAt==false)
                {
                    senatorSounds.OmeletteSound();
                    isStaredAt = true;
                }
            }
            else if (isStaredAt == true)
            {
                isStaredAt = false;
            }

        }
        public void MoveSenator()
        {
            doorClosed = DoorCheck.CheckDoorStatus();
            Text.Draw($"{doorClosed}", new Vector2(0, 200));
            if (isPlayerAlive==true)
            {
                senatorMoveTick += Random.Integer(5, 50)*Time.DeltaTime;
                if (senatorMoveTick >= 100)
                {
                    senatorMoveTick = 0;
                    if (doorClosed==true && isStaredAt==false)
                    {
                        senatorScreen = Random.Integer(1, 6);
                    }
                    else if (isStaredAt==false)
                    {
                        senatorScreen = Random.Integer(0, 0);
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
        public void SenatorVoiceLine()
        {

        }
    }
}
