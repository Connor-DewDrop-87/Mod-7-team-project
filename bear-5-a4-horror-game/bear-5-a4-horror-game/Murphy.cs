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
    public class Murphy
    {
        Camera Camera = new Camera();
        Doors DoorCheck = new Doors();
        OST murphySounds = new OST();
        int cameraPosition;
        int murphyScreen = 3;
        Vector2 murphyPosition = new Vector2(300,400);
        float murphyMoveTick = 0;
        bool isPlayerAlive = true;
        bool hasScared = false;
        bool isStaredAt = false;
        float frames = 0;
        bool doorClosed;
        Texture2D murphy = Graphics.LoadTexture("../../../../../Assets/abral-officermurphy-idle-pose-color-rig.png");
        Texture2D[] murphyJumpScare = {
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare1.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare2.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare3.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare4.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare5.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare6.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare7.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare8.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare9.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare10.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare11.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare12.png"),
            Graphics.LoadTexture("../../../../../Jumpscares/Murphyjumpscare/murphyjscare13.png"),
            
            };
            
        
        public void DrawMurphy()
        {
            Text.Draw($"{murphyMoveTick}", new Vector2(0, 0));
            // Player can only switch camera while alive
            if (isPlayerAlive == true)
            {
                Camera.CameraButtons();
            }
            // Get Player Position
             cameraPosition = Camera.ShareScreenPosition();
            // Draw Senator if the Player can see them
            
            if (murphyScreen == 0)
            {
                isPlayerAlive = false;
                murphySounds.RedSunSound();
                if (frames < murphyJumpScare.Length)
                {
                    Graphics.Draw(murphyJumpScare[(int)frames], 0, 50);
                    frames += 0.25f;
                }
                else
                {
                    Graphics.Draw(murphy, 500, 200);
                    if (hasScared==false)
                    {
                        murphySounds.DontFuckSound();
                    }
                    hasScared = true;
                }
            }
            else if (cameraPosition == murphyScreen)
            {
               Graphics.Draw(murphy, murphyPosition);
                if (isStaredAt==false)
                {
                    murphySounds.OmeletteSound();
                    isStaredAt = true;
                }
            }
            else if (isStaredAt == true)
            {
                isStaredAt = false;
            }

        }
        public void MoveMurphy()
        {
            doorClosed = DoorCheck.CheckDoorStatus();
            Text.Draw($"{doorClosed}", new Vector2(0, 400));
            if (isPlayerAlive==true)
            {
                murphyMoveTick += Random.Integer(5, 50)*Time.DeltaTime;
                if (murphyMoveTick >= 100)
                {
                    murphyMoveTick = 0;
                    if (doorClosed==true && isStaredAt==false)
                    {
                        murphyScreen = Random.Integer(1, 6);
                    }
                    else if (isStaredAt==false)
                    {
                        murphyScreen = Random.Integer(0, 0);
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
