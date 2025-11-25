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
    public class BlueEmoji
    {
        Camera Camera = new Camera();
        Doors DoorCheck = new Doors();
        OST blueSounds = new OST();
        
        int cameraPosition;
        int blueScreen=4;
        Vector2 bluePosition = new Vector2(300,300);
        float blueMoveTick=0;
        bool isPlayerAlive = true;
        bool hasScared = false;
        bool isStaredAt = false;
        bool powerStatus = true;
        float frames = 0;
        bool doorClosed;
        Texture2D blueScary = Graphics.LoadTexture("../../../../../Assets/teeth.png");
        Texture2D[] blueTextures = {
           Graphics.LoadTexture("../../../../../Assets/smug.png"),
           Graphics.LoadTexture("../../../../../Assets/bat.png"),
           Graphics.LoadTexture("../../../../../Assets/look.png"),
           Graphics.LoadTexture("../../../../../Assets/snoop.png"),
           Graphics.LoadTexture("../../../../../Assets/laugh.png"),
           Graphics.LoadTexture("../../../../../Assets/happy.png"),
           Graphics.LoadTexture("../../../../../Assets/determined.png"),
           Graphics.LoadTexture("../../../../../Assets/mewing.png"),
        
    };
        int BlueEmojiChooser = Random.Integer(0, 7);



        public void DrawBlue()
        {
            
            // Player can only switch camera while alive
            if (isPlayerAlive == true)
            {
                Camera.CameraButtons();
            }
            // Get Player Position
             cameraPosition = Camera.ShareScreenPosition();
            // Draw Senator if the Player can see them
            
            if (blueScreen == 0)
            {
                isPlayerAlive = false;
                blueSounds.SunDownerVoiceLines(4);
                if (frames < blueTextures.Length)
                {
                    Graphics.Draw(blueScary, 300, 100);
                    frames += 0.1f;
                }
                else
                {
                    Graphics.Draw(blueScary, 300, 100);
                    if (hasScared==false)
                    {
                        blueSounds.RedSunSound();
                    }
                    hasScared = true;
                }
            }
            else if (cameraPosition == blueScreen)
            {
                Graphics.Draw(blueTextures[BlueEmojiChooser], bluePosition);
                if (isStaredAt==false)
                {
                    BlueEmojiChooser = Random.Integer(0, 7);
                    blueSounds.SunDownerVoiceLines(Random.Integer(1,8));
                    isStaredAt = true;
                }
            }
            else if (isStaredAt == true)
            {
                isStaredAt = false;
            }

        }
        public void MoveBlue()
        {
            powerStatus = DoorCheck.CheckPowerStatus();
            doorClosed = DoorCheck.CheckDoorStatus();
            if (isPlayerAlive==true)
            {
                blueMoveTick += Random.Integer(1, 100)*Time.DeltaTime;
                if (blueMoveTick >= 255)
                {
                    blueMoveTick = 0;
                    if (doorClosed==true && isStaredAt==false)
                    {
                        blueScreen = Random.Integer(1, 6);
                        blueSounds.SunDownerVoiceLines(9);
                    }
                    else if (isStaredAt==false)
                    {
                        blueScreen = Random.Integer(0, 6);
                        blueSounds.SunDownerVoiceLines(9);
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
