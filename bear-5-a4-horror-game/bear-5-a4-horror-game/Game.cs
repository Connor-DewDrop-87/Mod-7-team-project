// Include the namespaces (code libraries) you need below.
using System;
using System.IO;
using System.Numerics;
using System.Threading;

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
        Murphy Enemy2 = new Murphy();
        Doors MainDoor = new Doors();
        // Check if Player is Alive. True means they are, false means they aren't
        bool isAlive;
        Color brown = new Color(150, 75, 0);
        int ScreenPosition;
        Texture2D Pizzaria = Graphics.LoadTexture("../../../../../Assets/PizzaPlace.png");
        Color textColor = new Color(0, 170, 245);
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Albaquerque");
            Window.SetSize(800, 800);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            Rooms();
            Player.CameraPosition();
            // Background Music
            if (isAlive)
            {
                
            }
            isAlive = Enemy.HasNotKilledPlayer();
            if (isAlive==true)
            {
                isAlive = Enemy2.HasNotKilledPlayer();
            }
            if (isAlive == true)
            {
                Player.CameraButtons();
            }
            if (isAlive == false)
            {
                Text.Color = textColor;
                Text.Draw("YOU DIED IN", new Vector2(200, 0));
            }
            // If you need a screen position for where the monster is, then use Camera.ShareScreenPosition();
            ScreenPosition = Player.ShareScreenPosition();
            // Draw and Update Movement of Senator
            Enemy.MoveSenator();
            Enemy.DrawSenator();

            // Draw and Update Movement of Murphy
            Enemy2.MoveMurphy();
            Enemy2.DrawMurphy();

            if (isAlive == true)
            {
                MainDoor.DoorToggle();
            }
            
        }
            

        
        public void Rooms()
        {
            // Office Screen
            if (ScreenPosition == 0)
            {
                // Door Void
                Draw.FillColor = Color.Black;
                Draw.Rectangle(new Vector2(240, 120), new Vector2(320, 240));
                // Door
                MainDoor.CreateDoor(new Vector2(400, 120), new Vector2(400, 360), new Vector2(160, 0), new Vector2(160, 0));
                // Desk
                Draw.FillColor = brown;
                Draw.Rectangle(new Vector2(40, 600), new Vector2(720, 120));
                // Wall outlines to add depth
                Draw.Line(new Vector2(0, 540), new Vector2(160, 360));
                Draw.Line(new Vector2(800, 520), new Vector2(640, 360));
                Draw.Line(new Vector2(160, 0), new Vector2(160, 360));
                Draw.Line(new Vector2(640, 0), new Vector2(640, 360));
                Draw.Line(new Vector2(160, 360), new Vector2(640, 360));
                float frames = Time.DeltaTime;
                Text.Draw($"{frames}", new Vector2(300, 400));
            }
            // HallWayA Screen
            if (ScreenPosition == 1)
            {

            }
            // RoomA Screen
            if (ScreenPosition == 2)
            {

            }
            // SenatorContainment Screen
            if (ScreenPosition == 3)
            {
                // Stage
                Graphics.Draw(Pizzaria, 0,0);
            }
            // RoomB Screen
            if (ScreenPosition == 4)
            {

            }
            // Vent Screen
            if (ScreenPosition == 5)
            {

            }
            // HallwayB Screen
            if (ScreenPosition == 6)
            {

            }
        }
        
       



    }


    }

