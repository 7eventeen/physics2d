using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace physics
{
    public class Shape
    {
        private int shapeId;
        private String shapeName;
        private Vector2f centerPos;
        private Vector2f rectSize;

        public Shape(String shapename, Vector2f centerPos)
        {
            this.shapeName = shapename;
            if (shapename.Equals("circle"))
            {
                shapeId = 0;
                this.centerPos = centerPos;
            }

            else if (shapename.Equals("rectangle"))
            {
                shapeId = 1;
                this.centerPos = centerPos;
            }

            else
            {
                throw new Exception("cannot find that shapename");
            }
        }

        public void RectangleSize(Vector2f rectSize)
        {
            this.rectSize = rectSize;
        }

        public int GetShapeId()
        {
            return shapeId;
        }

        public String GetShapeName()
        {
            return shapeName;
        }
        
        public

        
    }
}
