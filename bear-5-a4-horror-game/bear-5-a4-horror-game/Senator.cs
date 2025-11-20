using System;
using MohawkGame2D;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Senator
    {
        Camera Camera = new Camera();
        Doors DoorCheck = new Doors();
        int cameraPosition;
        int senatorScreen=3;
        Vector2 senatorPosition = new Vector2(100,100);
        float senatorMoveTick=0;
        bool isPlayerAlive = true;
        bool doorClosed;
        Texture2D senator = Graphics.LoadTexture("../../../../../Assets/thing.png");
        
        public void DrawSenator()
        {
            Text.Draw($"{senatorMoveTick}", new Vector2(0, 0));
            // Player can only switch camera while alive
            if (isPlayerAlive == true)
            {
                Camera.CameraPosition();
            }
            // Get Player Position
             cameraPosition = Camera.ShareScreenPosition();
            // Draw Senator if the Player can see them
            if (cameraPosition == senatorScreen)
            {
                Graphics.Draw(senator, senatorPosition);
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
                    if (doorClosed==true)
                    {
                        senatorScreen = Random.Integer(1, 1);
                    }
                    else
                    {
                        senatorScreen = Random.Integer(0, 0);
                    }     
                }
            }
        }
        public bool HasNotKilledPlayer()
        {
            if (isPlayerAlive == false)
            {
                return false;
            }
            return true;
        }
        public void DeathToggle()
        {
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                isPlayerAlive = !isPlayerAlive;
            }
        }
    }
}
