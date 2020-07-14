using SFML.Graphics;
using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace physics
{
    public class Graphics
    {
        RenderWindow app;

        public Graphics(RenderWindow app)
        {
            this.app = app;
        }

        public void DrawCircle(float radius, Vector2f pos)
        {
            CircleShape circle = new CircleShape(radius);
            circle.Position = pos;
            app.Draw(circle);
        }
    }
}
