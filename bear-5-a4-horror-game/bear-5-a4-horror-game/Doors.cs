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
        bool doorClosed = false;
        // Power on is true, Power off is false
        bool powerIsOn = true;
        public void CreateDoor(Vector2 doorCentreUpper, Vector2 doorCentreLower, Vector2 offSetR, Vector2 offSetL)
        {
            Draw.FillColor = Color.LightGray;
            CheckPowerStatus();
            // Door State Checker
            if (doorClosed)
            {
                // Door Right side
                Draw.Quad(doorCentreUpper, doorCentreUpper + offSetR, doorCentreLower + offSetR, doorCentreLower);
                // Door Left Side
                Draw.Quad(doorCentreUpper, doorCentreUpper - offSetL, doorCentreLower - offSetL, doorCentreLower);
            }
            if (!doorClosed)
            {
                // Door Right side
                Draw.Quad(doorCentreUpper + offSetR - new Vector2(10,0), doorCentreUpper + offSetR, doorCentreLower + offSetR, doorCentreLower + offSetR - new Vector2(10, 0));
                // Door Left Side
                Draw.Quad(doorCentreUpper - offSetL + new Vector2(10, 0), doorCentreUpper - offSetL, doorCentreLower - offSetL, doorCentreLower - offSetL + new Vector2(10, 0));
            }
        }
        public void DoorToggle()
        {
            if (Input.IsKeyboardKeyPressed(KeyboardInput.W))
            {
                if (powerIsOn == true)
                {
                    doorClosed = !doorClosed;
                }
                else
                {
                    doorClosed = false;
                }
            }
        }
        public bool CheckDoorStatus()
        {
            DoorToggle();
            CheckPowerStatus();
            if (doorClosed == true)
            {
                if (powerIsOn == true)
                {
                    return true;
                }
            }
            return false;

        }
        public bool CheckPowerStatus()
        {
            if (powerIsOn == false)
            {
                doorClosed = false;
            }
            return powerIsOn;
        }
        
    }
}
