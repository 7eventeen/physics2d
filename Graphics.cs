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

        public void DrawShape(Shape shape)
        {
            Vector2f centerPos = shape.GetCenterPos();

            if (shape.GetShapeId().Equals(0))
            {
                float radius = shape.GetCircleRadius();
                DrawCircle(radius, centerPos);
            }
            else if (shape.GetShapeId().Equals(1))
            {
                Vector2f rectSize = shape.GetRectangleSize();
                DrawRectangle(rectSize, centerPos);
            }

        }

        private void DrawCircle(float radius, Vector2f centerPos)
        {
            CircleShape circle = new CircleShape(radius);
            circle.Position = centerPos;
            app.Draw(circle);
        }

        private void DrawRectangle(Vector2f size, Vector2f centerPos)
        {
            RectangleShape rectangle = new RectangleShape(size);
            try
            {
                Image img1 = new Image(@"Resources\texture.jfif");
                Texture texture = new Texture(img1);
                rectangle.Texture = texture;
            } catch (SFML.LoadingFailedException e)
            {
                Console.Out.WriteLine("E");
            }
            rectangle.Position = centerPos;
            app.Draw(rectangle);
        }
    }
}
