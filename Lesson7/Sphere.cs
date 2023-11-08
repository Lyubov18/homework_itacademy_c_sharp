using System;

namespace Lesson7
{
    public class Sphere
    {
        private double _xCenter;

        private double _yCenter;

        private double _zCenter;

        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                if (value > 0)
                {
                    _radius = value;
                }
                else
                {
                    Console.WriteLine("Радиус должен принимать значение больше нуля");
                }
            }
        }


        public Sphere()
        {
            (_xCenter, _yCenter, _zCenter) = (0, 0, 0);
            _radius = 1;
        }

        public Sphere(double radius)
        {
            (_xCenter, _yCenter, _zCenter) = (0, 0, 0);
            _radius = radius;
        }

        public Sphere(double radius, double xCenter, double yCenter, double zCenter)
        {
            (_xCenter, _yCenter, _zCenter) = (xCenter, yCenter, zCenter);
            _radius = radius;
        }

        public double GetVolume()
        {
            return 4 / 3 * Math.PI * _radius * _radius * _radius;
        }

        public double GetSquare()
        {
            return 4 * Math.PI * _radius * _radius;
        }

        public string GetCenter()
        {
            return _xCenter.ToString() + " " + _yCenter.ToString() + " " + _zCenter.ToString();
        }

        public void SetCenter(double x, double y, double z)
        {
            (_xCenter, _yCenter, _zCenter) = (x, y, z);
        }

        public bool IsPointInside(double x, double y, double z)
        {
            double distanceSquared = (x - _xCenter) * (x - _xCenter) + (y - _yCenter) * (y - _yCenter) + (z - _zCenter) * (z - _zCenter);
            return distanceSquared < _radius * _radius;
        }
    }
}
