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

        public int GetShapeId()
        {
            return shapeId;
        }

        public String GetShapeName()
        {
            return shapeName;
        }

        public Vector2f GetCenterPos()
        {
            return centerPos;
        }

        public void SetCenterPos(Vector2f centerPos)
        {
            this.centerPos = centerPos;
        }

        public Vector2f GetRectangleSize()
        {
            if (rectSize != null)
            {
                return rectSize;
            }
            throw new Exception("rectSize isn't exist!");
        }

        public void SetRectangleSize(Vector2f rectSize)
        {
            this.rectSize = rectSize;
        }






        
    }
}
