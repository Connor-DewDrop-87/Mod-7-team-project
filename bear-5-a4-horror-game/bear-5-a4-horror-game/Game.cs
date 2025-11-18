// Include the namespaces (code libraries) you need below.
using System;
using System.IO;
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
        Camera Player = new Camera();
        Senator Enemy = new Senator();
        Doors MainDoor = new Doors();
        // Check if Player is Alive. True means they are, false means they aren't
        bool isAlive;
        Color brown = new Color(150, 75, 0);
        int ScreenPosition;
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            string cwd = Directory.GetCurrentDirectory();
            Console.WriteLine($"Current Directory: {cwd}");
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
            Music.BackgroundMusic();
            isAlive = Enemy.HasNotKilledPlayer();
            if (isAlive == true)
            {
                Player.CameraPosition();
            }
            // If you need a screen position for where the monster is, then use Camera.ShareScreenPosition();
            if (isAlive == false)
            {
                ScreenPosition = 7;
                
            }
            else
            {
                ScreenPosition = Player.ShareScreenPosition();
            }
            Enemy.DeathToggle();
            // Draw and Update Movement of Senator
            Enemy.MoveSenator();
            Enemy.DrawSenator();
            // Office Screen
            if (ScreenPosition == 0)
            {
                // Door
                MainDoor.CreateDoor(new Vector2(200,60),new Vector2(200,180));
                // Desk
                Draw.FillColor = brown;
                Draw.Rectangle(new Vector2(20,300), new Vector2(360,60));
                // Wall outlines to add depth
                Draw.Line(new Vector2(0, 260), new Vector2(80, 180));
                Draw.Line(new Vector2(400, 260), new Vector2(320, 180));
                Draw.Line(new Vector2(80, 0), new Vector2(80, 180));
                Draw.Line(new Vector2(320, 0), new Vector2(320, 180));
                Draw.Line(new Vector2(80, 180), new Vector2(320, 180));
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
            // Death Screen
            if (ScreenPosition == 7)
            {
                Draw.FillColor = Color.LightGray;
                Draw.Rectangle(new Vector2(0, 0), new Vector2(400, 400));
                Draw.FillColor = Color.Black;
                Text.Draw("YOU DIED", new Vector2(150, 0));
            }
        }
        
        
        
    }

}
