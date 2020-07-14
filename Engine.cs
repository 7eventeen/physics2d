using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace physics
{
    public class Engine
    {

        RenderWindow app;
        Graphics g;
        private static Color windowColor = new Color(0, 0, 0);

        public void Run()
        {
            CreateWindow();
            InitLoop();
        }

        private void OnClose(object sender, EventArgs e)
        {
            RenderWindow window = (RenderWindow)sender;
            window.Close();
        }

        private void CreateWindow()
        {
            app = new RenderWindow(new VideoMode(1024, 768), "SFML Works");
            app.Closed += new EventHandler(OnClose);

            g = new Graphics(app);

            Vector2u size = app.Size;
            Console.Out.WriteLine(size.X);
        }

        private void InitLoop()
        {
            while (app.IsOpen)
            {

                // Process events
                app.DispatchEvents();

                // Clear screen
                app.Clear(windowColor);

                // Update the window

                Shape rect = new Shape("rectangle", new Vector2f(100, 100));
                rect.SetRectangleSize(new Vector2f(300, 300));
                g.DrawShape(rect);

                app.Display();

     

            

            }
        }
    }
}
