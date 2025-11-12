using System;
using MohawkGame2D;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Direction
    {
        // 0 is north, 1 is east, 2 is south, and 3 is west
        int currentCamera = 0;
        string[] currentDirection =
        {
            "Office","HallWayC","OptionalRoomB", "SenatorContainment","OptionalRoomA", "Vent", "Hallway A"
        };

        public void CameraHud()
        {
            // Blocks for turning directions
            Draw.Rectangle(new Vector2(10, 300), new Vector2(50));
            Draw.Rectangle(new Vector2(340, 300), new Vector2(50));
            // Display Direction in Text
            Text.Draw($"{currentDirection[currentCamera]}", new Vector2(0, 0));
        }
        public void CameraSwitch()
        {
            // Turn Camera Left
            if (Input.IsKeyboardKeyPressed(KeyboardInput.A))
            {
               
                currentCamera--;
                // Loop camera back to west position
                if (currentCamera < 0)
                {
                    currentCamera = 6;
                }
            }
            // Turn Camera Right
            if (Input.IsKeyboardKeyPressed(KeyboardInput.D))
            {
                currentCamera++;
                // Loop camera back to north position
                if (currentCamera > 6)
                {
                    currentCamera = 0;
                }
            }
            
        }
        public int ShareScreenPosition()
        {
            return currentCamera;
        }

    }
}
