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
        bool openingSceneHasPlayed = false;
        // Timer to end game
        bool hasReached6am = false;
        float timeInSeconds = 0;
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
            if (openingSceneHasPlayed==false)
            {
                Music.OpeningScene();
                if (Music.OpeningScene() == false)
                {
                    openingSceneHasPlayed = true;
                }
            }
            if (openingSceneHasPlayed==true && timeInSeconds<360)
            {
                Window.ClearBackground(Color.OffWhite);
                Rooms();
                Player.CameraPosition();
                isAlive = Enemy.HasNotKilledPlayer();
                if (isAlive == true)
                {
                    isAlive = Enemy2.HasNotKilledPlayer();
                }
                if (isAlive == true)
                {
                    Player.CameraButtons();
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
                    CheckTime();
                }
                if (isAlive == false)
                {
                    Draw.FillColor = Color.Black;
                    Draw.Square(new Vector2(0, 0), 800);
                    Text.Color = textColor;
                    Text.Draw("YOU DIED IN", new Vector2(200, 0));
                    Player.CameraPosition();
                }
            }
            if (timeInSeconds>=360)
            {
                Window.ClearBackground(Color.OffWhite);
                Text.Color = textColor;
                Text.Draw($"6AM!!! YOU WIN!!!", new Vector2(200, 400));
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

        public void CheckTime()
        {
            timeInSeconds += Time.DeltaTime;
            if ( timeInSeconds>=0 && timeInSeconds < 60)
            {
                Text.Color = textColor;
                Text.Draw($"12AM", new Vector2(200, 0));
            }
            if ( timeInSeconds>=60 && timeInSeconds < 120)
            {
                Text.Color = textColor;
                Text.Draw($"1AM", new Vector2(200, 0));
            }
            if ( timeInSeconds>=120 && timeInSeconds < 180)
            {
                Text.Color = textColor;
                Text.Draw($"2AM", new Vector2(200, 0));
            }
            if ( timeInSeconds>=180 && timeInSeconds < 240)
            {
                Text.Color = textColor;
                Text.Draw($"3AM", new Vector2(200, 0));
            }
            if ( timeInSeconds>=240 && timeInSeconds < 300)
            {
                Text.Color = textColor;
                Text.Draw($"4AM", new Vector2(200, 0));
            }
            if ( timeInSeconds>=300 && timeInSeconds < 360)
            {
                Text.Color = textColor;
                Text.Draw($"5AM", new Vector2(200, 0));
            }
        }
        
       



    }


    }

