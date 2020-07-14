using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace physics
{
    public class Shape
    {
        private int shapeId;
        private float circleRadius = 0;
        private String shapeName;
        private Vector2f centerPos;
        private Vector2f rectSize = new Vector2f(0, 0);

        public Shape(String shapename, Vector2f centerPos)
        {
            this.shapeName = shapename;
            this.centerPos = centerPos;
            if (shapename.Equals("circle"))
            {
                shapeId = 0;
            }

            else if (shapename.Equals("rectangle"))
            {
                shapeId = 1;
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

        public void SetCircleRadius(float radius)
        {
            this.circleRadius = radius;
        }

        public float GetCircleRadius()
        {
            if (circleRadius != 0)
            {
                return circleRadius;
            }
            throw new Exception("circleRadius isn't exist!");
        }

        public Vector2f GetRectangleSize()
        {
            if (rectSize != new Vector2f(0, 0))
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
