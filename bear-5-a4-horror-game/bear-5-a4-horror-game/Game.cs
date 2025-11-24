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
        SunDowner Enemy3 = new SunDowner();
        Doors MainDoor = new Doors();
        // Check if Player is Alive. True means they are, false means they aren't
        bool isAlive = true;
        bool openingSceneHasPlayed = false;
        bool powerStatus = true;
        // Kill Screen
        bool hasClickedNoGod = false;
        int textX = 0;
        int textY = 0;
        // Timer to end game
        float timeInSeconds = 0;
        Color brown = new Color(150, 75, 0);
        int ScreenPosition;
        Texture2D Pizzaria = Graphics.LoadTexture("../../../../../Assets/PizzaPlace.png");
        Texture2D Office = Graphics.LoadTexture("../../../../../Assets/Office.png");
        Texture2D HallwayA = Graphics.LoadTexture("../../../../../Assets/WestHallNoCamera.png");
        Texture2D HallwayB = Graphics.LoadTexture("../../../../../Assets/Main_Hall.png");
        Texture2D Vent = Graphics.LoadTexture("../../../../../Assets/Vent.png");
        Texture2D PartyRoom = Graphics.LoadTexture("../../../../../Assets/RoomA.png");
        Texture2D SafeRoom = Graphics.LoadTexture("../../../../../Assets/RoomB.png");
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
            if (openingSceneHasPlayed==true && timeInSeconds<360 && isAlive==true)
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
                    isAlive = Enemy3.HasNotKilledPlayer();
                }
                Player.CameraButtons();
                MainDoor.CheckPowerStatus();
                powerStatus = MainDoor.CheckPowerStatus();
                if (powerStatus==true)
                {
                    Music.BackgroundMusic(1);
                }
                if (powerStatus==false)
                {
                    Music.BackgroundMusic(2);
                }
                int power = MainDoor.PowerUI();
                Text.Draw($"Power:{power}", new Vector2(600, 0));
                // If you need a screen position for where the monster is, then use Camera.ShareScreenPosition();
                ScreenPosition = Player.ShareScreenPosition();
                // Draw and Update Movement of Senator
                Enemy.MoveSenator();
                Enemy.DrawSenator();
                // Draw and Update Movement of Murphy
                Enemy2.MoveMurphy();
                Enemy2.DrawMurphy();
                // Draw and Update Movement of SunDowner
                Enemy3.MoveSunDowner();
                Enemy3.DrawSunDowner();
                // Player can open or close door
                MainDoor.DoorToggle();
                // Check the time to see if game is won
                CheckTime();
                
            }
            if (isAlive==false)
            {
                Draw.FillColor = Color.Black;
                Draw.Square(new Vector2(0, 0), 800);
                Text.Color = textColor;
                Text.Draw("YOU DIED IN", new Vector2(200, 0));
                Text.Draw("Press Space to Enter Heaven", new Vector2(200, 200));
                Player.CameraPosition();
                if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
                {
                    hasClickedNoGod = true;
                }
                if (hasClickedNoGod==true)
                {
                    for (int i = 0; i < 800; i++)
                    {
                        Text.Draw("THERE IS NO GOD!!!", new Vector2(textX, textY));

                        if (textX > 800)
                        {
                            textX = 0;
                        }
                        if (textY > 800)
                        {
                            textY = 0;
                            textX+=i;
                        }
                        else
                        {
                            textY+=i;
                        }
                    }
                }
            }
            if (timeInSeconds>=360)
            {
                Window.ClearBackground(Color.OffWhite);
                Music.BackgroundMusic(3);
                // Create the you win screen with credits
                Text.Color = textColor;
                Text.Draw($"6AM!!! YOU WIN!!! Credits:", new Vector2(100, 300));
                Text.Draw($"Connor Almeyda (Programmer)", new Vector2(100, 400));
                Text.Draw($"Keaton Speers (Music and Sound Designer)", new Vector2(100, 450));
                Text.Draw($"Aidan Thomas (Asset Designer and Scratch Reference Maker)", new Vector2(100, 500));
            }
            
            
        }
            

        
        public void Rooms()
        {
            // Office Screen
            if (ScreenPosition == 0)
            {
                Graphics.Draw(Office, 0, 0);
                // Door
                MainDoor.CreateDoor(new Vector2(410, 184), new Vector2(410, 663), new Vector2(266, 0), new Vector2(266, 0));
                
            }
            // HallWayB Screen
            if (ScreenPosition == 1)
            {
                Graphics.Draw(HallwayB, 0, 0);
            }
            // Safe Room Screen
            if (ScreenPosition == 2)
            {
                Graphics.Draw(SafeRoom, 0, 0); 
            }
            // SenatorContainment Screen
            if (ScreenPosition == 3)
            {
                // Stage
                Graphics.Draw(Pizzaria, 0,0);
            }
            // Partyroom Screen
            if (ScreenPosition == 4)
            {
                Graphics.Draw(PartyRoom, 0, 0);
            }
            // Vent Screen
            if (ScreenPosition == 5)
            {
                Graphics.Draw(Vent, 0, 0);
            }
            // HallwayA Screen
            if (ScreenPosition == 6)
            {
                Graphics.Draw(HallwayA, 0, 0);
            }
        }

        public void CheckTime()
        {
            timeInSeconds += Time.DeltaTime;
            if ( timeInSeconds>=0 && timeInSeconds < 60)
            {
                Text.Color = textColor;
                Text.Draw($"Time: 12AM", new Vector2(0, 0));
            }
            if ( timeInSeconds>=60 && timeInSeconds < 120)
            {
                Text.Color = textColor;
                Text.Draw($"Time: 1AM", new Vector2(0, 0));
            }
            if ( timeInSeconds>=120 && timeInSeconds < 180)
            {
                Text.Color = textColor;
                Text.Draw($"Time: 2AM", new Vector2(0, 0));
            }
            if ( timeInSeconds>=180 && timeInSeconds < 240)
            {
                Text.Color = textColor;
                Text.Draw($"Time: 3AM", new Vector2(0, 0));
            }
            if ( timeInSeconds>=240 && timeInSeconds < 300)
            {
                Text.Color = textColor;
                Text.Draw($"Time: 4AM", new Vector2(0, 0));
            }
            if ( timeInSeconds>=300 && timeInSeconds < 360)
            {
                Text.Color = textColor;
                Text.Draw($"Time: 5AM", new Vector2(0, 0));
            }
        }
        
       



    }


    }

