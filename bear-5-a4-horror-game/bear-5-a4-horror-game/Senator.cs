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
        Direction Camera = new Direction();
        int cameraPosition;
        int senatorscreen=3;
        Vector2 senatorPosition;
        bool isPlayerAlive = true;
        public void DrawSenator()
        {
            // Player can only switch camera while alive
            if (isPlayerAlive == true)
            {
                Camera.CameraPosition();
            }
            // Get Player Position
             cameraPosition = Camera.ShareScreenPosition();
            // Draw Senator if the Player can see them
            if (cameraPosition == senatorscreen)
            {
                
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
