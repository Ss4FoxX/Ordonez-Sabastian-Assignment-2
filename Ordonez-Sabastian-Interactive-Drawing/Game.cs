// Include code libraries you need below (use the namespace).
using System;
using System.Data;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{

    ///     Your game code goes inside this class!

    public class Game
    { 
        //Opens and closes the ball.
        bool IsBallOpen = false;

        int[] ArrayX = { 400, 700, 100, 100, 700};
        int[] ArrayY = { 300, 500, 100, 500, 100};

        ///     Setup runs once before the game loop begins.
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Squares?");

            //uses 2 writelines to make space from the boot up code stuff. other 2 are the rules
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Use Certain keys on your keyboard (B, R, Y, M, G) to change the squares color!");
            Console.WriteLine("Space and Clicking the leeft mouse button closes the ball, and turns any squares black");

        }

        ///     Update runs every frame.
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
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.Y))
                {
                    Draw.FillColor = Color.Yellow;
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.M))
                {
                    Draw.FillColor = Color.Magenta;
                }
                else if (Input.IsKeyboardKeyPressed(KeyboardInput.G))
                {
                    Draw.FillColor = Color.LightGray;
                }


                    //Draw.Square(ArrayX[0] / 2, ArrayY[0] / 2, 100);  spare Ctrl C code
                    if (Input.IsMouseButtonPressed(MouseInput.Left) || Input.IsKeyboardKeyPressed(KeyboardInput.Space))
                {
                    IsBallOpen = false;
                }
                    //The Circles
                Draw.Square(ArrayX[0] -50, ArrayY[0] -50, 100);
                Draw.Square(ArrayX[1] -50, ArrayY[1] -50, 100);
                Draw.Square(ArrayX[2] -50, ArrayY[2] -50, 100);
                Draw.Square(ArrayX[3] -50, ArrayY[3] -50, 100);
                Draw.Square(ArrayX[4] -50, ArrayY[4] -50, 100);

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
                Draw.Circle(ArrayX[1], ArrayY[1], 100);
                Draw.Circle(ArrayX[2], ArrayY[2], 100);
                Draw.Circle(ArrayX[3], ArrayY[3], 100);
                Draw.Circle(ArrayX[4], ArrayY[4], 100);

                Draw.FillColor = Color.White;

                if (Input.IsMouseButtonPressed(MouseInput.Left) || Input.IsKeyboardKeyPressed(KeyboardInput.Space))
                {
                    IsBallOpen = true;
                    Draw.FillColor = Color.White;
                }
            }



        }
    }
}
