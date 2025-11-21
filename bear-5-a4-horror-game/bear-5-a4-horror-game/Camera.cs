using System;
using MohawkGame2D;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohawkGame2D
{
    public class Camera
    {
        int currentCamera = 0;
        string[] currentPosition =
        {
            "OFFICE","HALLWAYA","ROOMA", "BRIDGE","ROOMB", "VENT", "HALLWAYB"
        };
        Color textColor = new Color(0, 170, 245);
        public void CameraPosition()
        {
            // Display Direction in Text

            Text.Color = textColor;
            Text.Draw($"{currentPosition[currentCamera]}", new Vector2(400, 0));
        }
        public void CameraButtons()
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
            
        

