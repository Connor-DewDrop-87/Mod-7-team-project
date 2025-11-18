using System;
using MohawkGame2D;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Doors
    {
        // Open is false, Closed is true
        bool doorShut = false;
        // Power on is true, Power off is false
        bool powerIsOn = true;
        public void CreateDoor(Vector2 doorCentreUpper, Vector2 doorCentreLower)
        {
            Draw.FillColor = Color.LightGray;
            // Door State Checker
            if (doorShut)
            {
                // Door Right side
                Draw.Quad(doorCentreUpper, doorCentreUpper + new Vector2(80, 0), doorCentreLower + new Vector2(80, 0), doorCentreLower);
                // Door Left Side
                Draw.Quad(doorCentreUpper, doorCentreUpper - new Vector2(80, 0), doorCentreLower - new Vector2(80, 0), doorCentreLower);
            }
            if (!doorShut)
            {
                // Door Right side
                Draw.Quad(doorCentreUpper + new Vector2(70, 0), doorCentreUpper + new Vector2(80, 0), doorCentreLower + new Vector2(80, 0), doorCentreLower + new Vector2(70, 0));
                // Door Left Side
                Draw.Quad(doorCentreUpper - new Vector2(70, 0), doorCentreUpper - new Vector2(80, 0), doorCentreLower - new Vector2(80, 0), doorCentreLower - new Vector2(70, 0));
            }
            // Door on/off switch
            if (Input.IsKeyboardKeyPressed(KeyboardInput.W))
            {
                if (powerIsOn == true)
                {
                    doorShut = !doorShut;
                }
            }
        }
    }
}
