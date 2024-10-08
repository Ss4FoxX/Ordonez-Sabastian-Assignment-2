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

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 800);
            Window.SetTitle("Squares?");


        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Gray);


            // Draws a ball

            /*
            Draw.LineColor = Color.Black;
            Draw.LineSize = 5;
            Draw.FillColor = Color.Red;
            Draw.Circle(400, 400, 200);

            Draw.LineColor = Color.Black;
            Draw.LineSize = 15;
            Draw.Line(207, 400, 596, 400);

            Draw.LineSize = 5;
            Draw.FillColor = Color.Black;
            Draw.Circle(400, 400, 50);

            Draw.FillColor = Color.White;
            Draw.Circle(400, 400, 25); */


            // Checks if the ball is open or closed
            if (IsBallOpen == true)
            {
                //If it is open, pressing a key will draw a different coloured square over the ball.
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

                Draw.Square(300 , 300, 200);
            }

            // checks if the ball is closed
            else if (IsBallOpen == false)
            {

                //if ball is closed, creates closed pokeball, when pressed opens a white square

                Draw.LineColor = Color.Black;
                Draw.LineSize = 5;
                Draw.FillColor = Color.Red;
                Draw.Circle(400, 400, 200);

                Draw.LineColor = Color.Black;
                Draw.LineSize = 15;
                Draw.Line(207, 400, 596, 400);

                Draw.LineSize = 5;
                Draw.FillColor = Color.Black;
                Draw.Circle(400, 400, 50);

                Draw.FillColor = Color.White;
                Draw.Circle(400, 400, 25);

                if (Input.IsMouseButtonPressed(MouseInput.Left) || Input.IsKeyboardKeyPressed(KeyboardInput.Space))
                {
                    IsBallOpen = true;
                    Draw.FillColor = Color.White;
                }
            }



        }
    }
}
