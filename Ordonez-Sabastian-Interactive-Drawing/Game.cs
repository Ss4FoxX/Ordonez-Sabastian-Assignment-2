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
        //Opens and closes the pokeball.
        bool IsBallOpen = false;
        int Changer;



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

            Changer = Console.ReadLine();

            Console.ReadLine();

            Window.ClearBackground(Color.Gray);

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

            if (IsBallOpen == true)
            {

                if (Changer == "1")
                {
                    Draw.FillColor = Color.Blue;
                    Draw.Square(400, 400, 300);
                }
                else if (Changer == "2")
                {
                    Draw.FillColor = Color.Red;
                    Draw.Square(400, 400, 300);
                }





                if (Input.IsMouseButtonPressed(MouseInput.Left))
                {
                    IsBallOpen = false;
                }
            }
            else if (IsBallOpen == false)
            {
                Draw.FillColor= Color.Black;
                Draw.Square(400, 400, 300);
                if (Input.IsMouseButtonPressed(MouseInput.Left))
                {
                    IsBallOpen = true;
                }
            }



        }
    }
}
