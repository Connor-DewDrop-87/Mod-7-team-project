// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        OST Music = new OST();
        Direction Camera = new Direction();
        bool isAlive = true;
        // Open is false, Closed is true
        bool doorShut = false;
        // Power on is true, Power off is false
        bool powerIsOn = true;
        int ScreenPosition;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Albaquerque");
            Window.SetSize(400,400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            Music.BackgroundMusic();
            Camera.CameraHud();
            Camera.CameraSwitch();
            // If you need a screen position for where the monster is, then use Camera.ShareScreenPosition();
            ScreenPosition = Camera.ShareScreenPosition();
            // Office Screen
            if (ScreenPosition == 0)
            {
                // Door
                ShutOrOpenDoor();
            }
            // HallWayC Screen
            if (ScreenPosition == 1)
            {

            }
            // OptionalRoomB Screen
            if (ScreenPosition == 2)
            {

            }
            // SenatorContainment Screen
            if (ScreenPosition == 3)
            {

            }
            // OptionalRoomA Screen
            if (ScreenPosition == 4)
            {

            }
            // Vent Screen
            if (ScreenPosition == 5)
            {

            }
            // Hallway A Screen
            if (ScreenPosition == 6)
            {

            }
        }
        public void ShutOrOpenDoor()
        {
            // Door State Checker
            if (doorShut)
            {
                Draw.Rectangle(new Vector2(Window.Width / 2, Window.Height / 2), new Vector2(50, 50));
            }
            if (!doorShut)
            {
                Draw.Rectangle(new Vector2(Window.Width / 2, Window.Height / 2), new Vector2(50, 20));
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
