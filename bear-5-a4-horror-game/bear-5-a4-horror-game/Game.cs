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
        Color brown = new Color(150, 75, 0);
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
            // Make walls of the screen based on ScreenPosition
            CreateWalls();
            // Office Screen
            if (ScreenPosition == 0)
            {
                // Door
                CreateDoor(new Vector2(200,60), new Vector2(200,180));
                // Desk
                Draw.FillColor = brown;
                Draw.Rectangle(new Vector2(20,300), new Vector2(360,60));
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
        public void CreateDoor(Vector2 doorCentreUpper,Vector2 doorCentreLower)
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
                Draw.Quad(doorCentreUpper+new Vector2(70,0), doorCentreUpper + new Vector2(80, 0), doorCentreLower + new Vector2(80, 0), doorCentreLower + new Vector2(70, 0));
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
        public void CreateWalls()
        {
            // Office Screen
            if (ScreenPosition == 0)
            {
                Draw.Line(new Vector2(0, 260),new Vector2(80,180));
                Draw.Line(new Vector2(400, 260),new Vector2(320,180));
                Draw.Line(new Vector2(80, 0),new Vector2(80,180));
                Draw.Line(new Vector2(320, 0),new Vector2(320,180));
                Draw.Line(new Vector2(80, 180), new Vector2(320,180));
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
    }

}
