// Include code libraries you need below (use the namespace).
using System;
using System.Data;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    { 
        //Opens and closes the ball.
        bool IsBallOpen = false;

        int[] ArrayX = { 110, 200, 600, 200, 400, 600};
        int[] ArrayY = { 110, 250, 250, 500, 500, 500};

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Squares?");

            //uses 2 writelines to make space from the boot up code stuff. other 2 are the rules
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Use Certain keys on your keyboard (B, R, Y, V, G) to change the squares color!");
            Console.WriteLine("Space and Clicking the leeft mouse button closes the ball, and turns any squares black");

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.DarkGray);
            if (IsBallOpen == true)
            {

                //If it is open, pressing a key will draw a coloured square over the ball.
                if (Input.IsKeyboardKeyPressed(KeyboardInput.B))
                {
                    Draw.FillColor = Color.Blue;
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.R))
                {
                    Draw.FillColor = Color.Red;
                }

                if (Input.IsMouseButtonPressed(MouseInput.Left) || Input.IsKeyboardKeyPressed(KeyboardInput.Space))
                {
                    IsBallOpen = false;
                }

                Draw.Square(ArrayX[0] /2, ArrayY[0] /2, 100);
            }

            // checks if the ball is closed
            else if (IsBallOpen == false)
            {

                //if ball is closed, creates closed pokeball, when pressed opens a white square

                Draw.LineColor = Color.Black;
                Draw.LineSize = 5;
                Draw.FillColor = Color.Red;
                Draw.Circle(ArrayX[0], ArrayY[0], 100);

                Draw.LineColor = Color.Black;
                Draw.LineSize = 10;
                Draw.Line(ArrayX[0] - 97, ArrayY[0], ArrayX[0] + 97, ArrayY[0]);

                Draw.LineSize = 5;
                Draw.FillColor = Color.Black;
                Draw.Circle(ArrayX[0], ArrayY[0], 50);

                Draw.FillColor = Color.White;
                Draw.Circle(ArrayX[0], ArrayY[0], 25);

                if (Input.IsMouseButtonPressed(MouseInput.Left) || Input.IsKeyboardKeyPressed(KeyboardInput.Space))
                {
                    IsBallOpen = true;
                    Draw.FillColor = Color.White;
                }
            }



        }
    }
}
