using SFML.Graphics;
using SFML.System;
using SFML.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace physics
{
    public class MainLoop
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
            app = new RenderWindow(new VideoMode(800, 600), "SFML Works");
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

                g.DrawCircle(100, new Vector2f(10, 200));
                app.Display();

            

            }
        }
    }
}
