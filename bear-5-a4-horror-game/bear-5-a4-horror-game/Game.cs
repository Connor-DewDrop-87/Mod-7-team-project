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
            // Background Music
            Music.Backgroundmusic();
            // Camera Directions
            Camera.CameraHud();
            Camera.CameraSwitch();
            // If you need a screen position for where the monster is, then use Camera.ShareScreenPosition();
            ScreenPosition = Camera.ShareScreenPosition();
        }
        public bool ShareDoorState()
        {
            if (doorShut)
            {
                return true;
            }
            return false;
        }
    }

}
